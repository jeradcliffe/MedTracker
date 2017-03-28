USE Clinic;

SELECT * FROM patients pt
	JOIN People ppl ON pt.peopleID = ppl.peopleID;

SELECT * FROM appointment;
-- Used later when adding buttons to DataGridView
SELECT * FROM appointment_has_tests;


-- Scrap work used to pull info for search table
-- aht.appointment_date is key to pull tests done
-- see a.appointment_date for matching pk/fk
-- no need to pull appointment date twice
SELECT DISTINCT
	   pt.patientID,
	   ppl.firstName,
	   ppl.lastName,
	   ppl.dateOfBirth, 
	   a.reasonForVisit, 
	   a.date
FROM patients pt 
	JOIN people ppl ON ppl.peopleID = pt.peopleID
	JOIN appointment a ON a.patientID = pt.patientID
	JOIN appointment_has_tests aht ON aht.appointment_patientID = pt.patientID
ORDER BY a.date;

-- Scrap work used to pull ALL info for search table
-- Get better picture of why so many of same apt dates from this angles
SELECT pt.patientID,
	   ppl.firstName,
	   ppl.lastName,
	   ppl.dateOfBirth, 
	   a.reasonForVisit,
	   aht.* 
FROM patients pt 
	JOIN people ppl ON ppl.peopleID = pt.peopleID
	JOIN appointment a ON a.patientID = pt.patientID
	JOIN appointment_has_tests aht ON aht.appointment_patientID = pt.patientID;