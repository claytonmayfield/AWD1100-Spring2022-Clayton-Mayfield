ALTER TABLE Appointments ADD CONSTRAINT FK_Appointments_Patients
FOREIGN KEY(PatID) REFERENCES Patients(PatID);

ALTER TABLE Appointments ADD CONSTRAINT FK_Appointments_AppointmentType
FOREIGN KEY (ATTypeID) REFERENCES AppointmentType (ATTypeID);