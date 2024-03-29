USE [CS6232-g3];
GO
IF OBJECT_ID('usp_mostPerformedTestsDuringDates') IS NOT NULL
	DROP PROC usp_mostPerformedTestsDuringDates;
GO
CREATE PROCEDURE usp_mostPerformedTestsDuringDates 
	@startDate date,
	@endDate date
AS
	/* Used so a row count is not returned */
	SET NOCOUNT ON;

	IF @startDate > @endDate
		THROW 50001, 'Start date is cannot be greater than end date', 1;
	IF @startDate > GETDATE() OR @endDate > GETDATE()
		THROW 50001, 'Date entered is greater than current date', 1;
	IF @endDate IS NULL
		THROW 50001, 'The end date cannot be null', 1;
	IF @startDate IS NULL
		THROW 50001, 'The start date cannot be null', 1;
	IF @startDate = ''
		THROW 50001, 'The start date is empty', 1;
	IF @endDate = ''
		THROW 50001, 'The end date is empty', 1;
	 
    SELECT main1.tests_testCode, main1.testName,  
           main1.timesTestPerformed, 
		   main2.total_performed,
		   ROUND(100 * main1.timesTestPerformed / main2.total_performed, 2),
		   main1.result,
		   main1.abnormal,
		   ROUND(100 * main1.agegroup18 / main1.timesTestPerformed, 2),
		   ROUND(100 * main1.otherAgeGroup / main1.timesTestPerformed, 2)
	FROM 
		(SELECT tests_testCode, 
				t2.testName, 
				COUNT(*) AS timesTestPerformed,
				sum(case when t1.results = 'Normal' then 1 else 0 end) AS result,
				sum(case when t1.results = 'Abnormal' then 1 else 0 end) AS abnormal,
				SUM(case when (DATEDIFF(YEAR, t4.dateOfBirth, t1.testDate) >= 18 AND DATEDIFF(YEAR, t4.dateOfBirth, t1.testDate) <= 29) then 1 else 0 end) AS agegroup18,
				SUM(case when (DATEDIFF(YEAR, t4.dateOfBirth, t1.testDate) < 18 OR DATEDIFF(YEAR, t4.dateOfBirth, t1.testDate) > 29) then 1 else 0 end) AS otherAgeGroup
		FROM
			appointment_has_tests t1
			JOIN tests t2 ON t2.testCode = t1.tests_testCode 
			JOIN patients t3 ON t3.patientID = t1.appointment_patientID
			JOIN people t4 ON t4.peopleID = t3.peopleID
		WHERE t1.testDate >= @startDate AND t1.testDate <= @endDate 
		GROUP BY t1.tests_testCode, t2.testName
		HAVING COUNT(*) > 1) main1,
		(SELECT COUNT(*) AS total_performed FROM appointment_has_tests WHERE 
		testDate >= @startDate AND testDate <= @endDate) main2
	ORDER BY main1.timesTestPerformed DESC, main1.tests_testCode DESC;
GO