/*Assignment 3 Page 213*/
/*Assignment 5-10: Returning a Record*/
SET SERVEROUTPUT ON
CREATE or replace PROCEDURE DDPROJ_SP (spID in DD_PROJECT.IDPROJ%TYPE, spData out DD_PROJECT%ROWTYPE) 
AS
BEGIN
select * into spData
from dd_project
where IDPROJ = spID;
DBMS_OUTPUT.PUT_LINE('Project ID: ' || spData.IDPROJ || ', Project Name: ' ||spData.PROJNAME|| ', Project Start Date: ' ||spData.PROJSTARTDATE
|| ', Project End Date: ' ||spData.PROJENDDATE|| ', Project Fundraising Goal: ' ||spData.PROJFUNDGOAL|| ', Project Coord: ' ||spData.PROJCOORD);
end DDPROJ_SP;


DECLARE
projectData DD_PROJECT%ROWTYPE;
projectID VARCHAR(45):= 500;
BEGIN
DDPROJ_SP(projectID, projectData);
end;

/*Assignment 5-11: Creating a Procedure*/
SET SERVEROUTPUT ON
CREATE or replace PROCEDURE DDPAY_SP (spPledgeId in DD_PLEDGE.IDPLEDGE%TYPE, spPledgeAmount in DD_PLEDGE.PLEDGEAMT%TYPE,
spPledgeData out DD_PLEDGE%ROWTYPE, spPledgeStatus out BOOLEAN) 
as
BEGIN
select * into spPledgeData
from dd_pledge
where IDPLEDGE = spPledgeId AND PAYMONTHS != 0;
IF spPledgeAmount != (spPledgeData.pledgeamt / spPledgeData.paymonths) then
spPledgeStatus := false;
else
spPledgeStatus := true;
end if;
end DDPAY_SP;

DECLARE
spPledgeID VARCHAR(45):= 104;
spPledgeAmount DD_PLEDGE.PLEDGEAMT%TYPE := 20; 
spPledgeData DD_PLEDGE%ROWTYPE;
spPledgeStatus BOOLEAN := false;
BEGIN
DDPAY_SP (spPledgeID,spPledgeAmount,spPledgeData,spPledgeStatus);
if spPledgeStatus = true then
DBMS_OUTPUT.PUT_LINE('Pledge Active');
else
DBMS_OUTPUT.PUT_LINE('Pledge Inactive');
end if;
END;

/*Assignment 5-12: Creating a Procedure*/
SET SERVEROUTPUT ON
CREATE or replace PROCEDURE DDCKPAY_SP (spPledgeId in DD_PLEDGE.IDPLEDGE%TYPE, spPledgeAmount in DD_PLEDGE.PLEDGEAMT%TYPE)
IS
spPayNum DD_PLEDGE.pledgeamt%TYPE;
BEGIN
SELECT SUM(pledgeamt/paymonths)
INTO spPayNum    
FROM dd_pledge
GROUP BY PLEDGEAMT;
DBMS_OUTPUT.PUT_LINE('Pledge Amount: ' || spPledgeAmount);
end DDCKPAY_SP;

DECLARE 
spPledgeId VARCHAR(45):= 104;
spPledgeAmount NUMBER:= 20; 
BEGIN 
DDCHKBAL_SP(spPledgeId, spPledgeAmount);
END;

/*Assignment 5-13: Creating a Procedure*/
SET SERVEROUTPUT ON;
CREATE or replace PROCEDURE DDCHKBAL_SP (spPledgeId IN DD_PLEDGE.IDPLEDGE%TYPE, spPledgeAmount OUT DD_PLEDGE.PLEDGEAMT%TYPE, 
spPledgeAmountTotal OUT NUMBER, spPledgeBalance OUT NUMBER) 
IS 
BEGIN 
SELECT PLEDGEAMT, SUM(PLEDGEAMT / PAYMONTHS), SUM(PLEDGEAMT) 
INTO spPledgeAmount, spPledgeAmountTotal, spPledgeBalance 
FROM DD_PLEDGE 
WHERE IDPLEDGE = spPledgeId 
GROUP BY PLEDGEAMT; 
spPledgeBalance := spPledgeBalance - spPledgeAmount; 
DBMS_OUTPUT.PUT_LINE('Pledge Amount: ' || spPledgeAmount || ', Payment Total to Date: ' || spPledgeAmountTotal || ', Balance Remaining: ' || spPledgeBalance);
END DDCHKBAL_SP; 

DECLARE 
spPledgeId VARCHAR(45):= 105;
spPledgeAmount DD_PLEDGE.PLEDGEAMT%TYPE; 
spPledgeAmountTotal NUMBER; 
spPledgeBalance NUMBER; 
BEGIN 
DDCHKBAL_SP(spPledgeId, spPledgeAmount, spPledgeAmountTotal, spPledgeBalance);
END;