/*1. List the name of each officer who has reported more than the average number of crimes officers have reported.*/
SELECT first, last, OFFICER_ID
FROM OFFICERS
Where OFFICER_ID IN ( SELECT OFFICER_ID
FROM(SELECT COUNT(CRIME_ID) AS Count_CRIME_ID, OFFICER_ID
FROM CRIME_OFFICERS
GROUP BY OFFICER_ID)
WHERE Count_CRIME_ID > (SELECT AVG(Count_CRIME_ID) AS Average_Count
FROM (SELECT COUNT(CRIME_ID) AS Count_CRIME_ID, OFFICER_ID
FROM CRIME_OFFICERS
GROUP BY OFFICER_ID)));

/*2. List the names of all criminals who have committed less than average number of crimes and aren’t listed as violent offenders.*/
SELECT first, last, CRIMINAL_ID
From CRIMINALS
Where (V_STATUS = 'N') and CRIMINAL_ID IN (SELECT CRIMINAL_ID
FROM(SELECT COUNT(CRIME_ID) AS Count_CRIME_ID, CRIMINAL_ID
FROM CRIMES
GROUP BY CRIMINAL_ID)
WHERE Count_CRIME_ID < (SELECT AVG(Count_CRIME_ID) AS Average_Count
FROM (SELECT COUNT(CRIME_ID) AS Count_CRIME_ID, CRIMINAL_ID
FROM CRIMES
GROUP BY CRIMINAL_ID)));

/*3. List appeal information for each appeal that has a less than average number of days between the filing and hearing dates.*/
SELECT *
FROM APPEALS
WHERE (HEARING_DATE - FILING_DATE) < ALL (SELECT AVG(HEARING_DATE - FILING_DATE)
FROM APPEALS)
Group by APPEAL_ID, CRIME_ID, STATUS, HEARING_DATE, FILING_DATE;

/*4. List the names of probation officers who have had a less than average number of criminals assigned.*/
SELECT *
FROM PROB_OFFICERS
WHERE PROB_ID IN (SELECT PROB_ID
FROM(SELECT COUNT(CRIMINAL_ID) AS SENTENCES_CRIME_ID, PROB_ID
FROM SENTENCES
GROUP BY PROB_ID)
WHERE SENTENCES_CRIME_ID < (SELECT AVG(SENTENCES_CRIME_ID)
FROM (SELECT COUNT(CRIMINAL_ID) AS SENTENCES_CRIME_ID, PROB_ID
FROM SENTENCES
GROUP BY PROB_ID)));

/*5. List each crime that has had the highest number of appeals recorded.*/
SELECT CRIME_ID
FROM APPEALS GROUP BY CRIME_ID 
HAVING COUNT(CRIME_ID) IN (SELECT COUNT(CRIME_ID) 
FROM CRIMES 
GROUP BY CRIME_ID);