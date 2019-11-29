/*Assignment 3-9: Retrieving Pledge Totals*/
SET SERVEROUTPUT ON
DECLARE
  projectId dd_project.IDPROJ%TYPE;
  projectIdName VARCHAR(45);
  pledgeNum NUMBER;
  totalPledges NUMBER;
  avgPledges NUMBER;
BEGIN
  
  SELECT dd_project.IDPROJ, dd_project.PROJNAME, COUNT(dd_project.IDPROJ), SUM(dd_pledge.PLEDGEAMT), avg(dd_pledge.PLEDGEAMT) 

  INTO projectId, projectIdName, pledgeNum, totalPledges, avgPledges
  FROM dd_project, dd_pledge
  WHERE dd_project.IDPROJ = 500 /* 502 503 504 501 500*/
  GROUP BY dd_project.IDPROJ, dd_project.PROJNAME;
  
  DBMS_OUTPUT.PUT_LINE('Project ID: ' || projectId || ', Project Name: '|| projectIdName || ', Number of Pledges Made: ' || pledgeNum 
  || ', Total Dollars Pledged: ' || TO_CHAR(totalPledges, '$9,999.00') || ', Average Pledge Amount: ' || TO_CHAR(avgPledges, '$9,999.99'));
END;

/*Assignment 3-10: Adding a Project*/
SET SERVEROUTPUT ON
CREATE SEQUENCE DD_PROJID_SEQ
START WITH 530
NOCACHE;

DECLARE
TYPE projectData IS RECORD 
(
  projectName dd_project.PROJNAME%TYPE:= 'HK Animal Shelter Extension',
  startDate dd_project.PROJSTARTDATE%TYPE:= '01-JAN-13',
  endDate dd_project.PROJENDDATE%TYPE:= '31-MAY-13',
  fundraisingGoal dd_project.PROJFUNDGOAL%TYPE:= '65000'
);
projectDataRec projectData; 
BEGIN
insert into dd_project(IDPROJ, PROJNAME, PROJSTARTDATE, PROJENDDATE, PROJFUNDGOAL)
VALUES(DD_PROJID_SEQ.nextval, projectDataRec.projectName, projectDataRec.startDate, projectDataRec.endDate, projectDataRec.fundraisingGoal);
COMMIT;
END;

/*Assignment 3-11: Retrieving and Displaying Pledge Data*/
SET SERVEROUTPUT ON
DECLARE
pledges dd_pledge%ROWTYPE;
startDate dd_pledge.PLEDGEDATE%TYPE := '01-OCT-12';
endDate dd_pledge.PLEDGEDATE%TYPE := '31-OCT-12';
payments dd_pledge.PAYMONTHS%TYPE;
BEGIN

FOR pledges IN 
(SELECT IDPLEDGE, IDDONOR, PLEDGEAMT,
CASE
  WHEN PAYMONTHS = 0 THEN 'Lump Sum.'
  ELSE 'Monthly - ' || PAYMONTHS
END AS
payments
FROM dd_pledge
WHERE PLEDGEDATE >= startDate AND PLEDGEDATE <= endDate
ORDER BY PAYMONTHS)

LOOP
DBMS_OUTPUT.PUT_LINE('Pledge ID: ' || pledges.IDPLEDGE || ', Donor ID: '|| pledges.IDDONOR || ', Pledge Amount: ' 
|| to_char(pledges.PLEDGEAMT, '$9,999.99') || ', Payments: ' || pledges.payments);
END LOOP;
END;

/*Assignment 3-12: Retrieving a Specific Pledge*/
SET SERVEROUTPUT ON
DECLARE
  pledges dd_pledge%ROWTYPE;
  pledgeID dd_pledge.IDPROJ%TYPE;
  pledgesPayed dd_pledge.PLEDGEAMT%TYPE;
  amount dd_pledge.PLEDGEAMT%TYPE;
  paided number (2);
BEGIN
SELECT *
INTO pledges
FROM dd_pledge
WHERE dd_pledge.IDPLEDGE = 105; /* 102 103 104 101 100*/

paided:= pledges.PAYMONTHS;
CASE 
WHEN pledges.PAYMONTHS = 0 THEN 
pledgesPayed:= pledges.PLEDGEAMT;
ELSE pledgesPayed:= paided * (pledges.PLEDGEAMT/pledges.PAYMONTHS);
END CASE;
paided:= pledges.PLEDGEAMT - pledgesPayed;

DBMS_OUTPUT.PUT_LINE('Pledge ID: ' || pledges.IDPLEDGE || ', Donor ID: ' || pledges.IDDONOR ||', Pledge Amount: ' 
|| pledgesPayed || ', Total Paid Amount: ' || paided);
END;

/*Assignment 3-13: Modifying Data*/
SET SERVEROUTPUT ON
DECLARE
projectId dd_project.IDPROJ%TYPE;
projectName dd_project.PROJNAME%TYPE;
projectDATE dd_project.PROJSTARTDATE%TYPE;
fundraisingGoal dd_project.PROJFUNDGOAL%TYPE;
newFundraisingGoal dd_project.PROJFUNDGOAL%TYPE;
BEGIN
SELECT PROJNAME, PROJSTARTDATE, PROJFUNDGOAL
INTO projectName, projectDATE, fundraisingGoal
FROM dd_project
WHERE IDPROJ = 503; /* 502 503 504 501 500*/
newFundraisingGoal:= 666;
UPDATE dd_project
SET PROJFUNDGOAL = newFundraisingGoal;
  
DBMS_OUTPUT.PUT_LINE('Project Name: ' || projectName ||', Start Date: ' || projectDATE || ', Previous Fundraising Goal: ' || fundraisingGoal 
|| ', New Fundraising Goal: ' || newFundraisingGoal);
END;