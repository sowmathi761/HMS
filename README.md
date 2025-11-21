# Hospital Management System (HMS)

A simple Windows Form Application built using **VB.NET** and **Oracle Database** to manage patients, doctors, and appointments.

---

## Features

* Add, update, delete Patients
* Add, update, delete Doctors
* Create and manage Appointments
* Connects to Oracle Database
* Clean and simple user interface
* Navigation menu for easy movement between forms

---

## Technologies Used

* VB.NET (Windows Forms)
* Visual Studio
* Oracle Database
* SQL Developer

---

## Project Structure

* `Form1.vb` – Navigation panel
* `PatientsForm.vb` – Patient CRUD
* `DoctorsForm.vb` – Doctor CRUD
* `AppointmentsForm.vb` – Appointment CRUD
* Oracle SQL queries included

---

## Database Tables

### Patients Table

* PATIENT_ID
* NAME
* AGE
* GENDER
* ADDRESS
* PHONE

### Doctors Table

* DOCTOR_ID
* NAME
* SPECIALIZATION
* EXPERIENCE
* PHONE

### Appointments Table

* APP_ID
* PATIENT_ID
* DOCTOR_ID
* APP_DATE
* STATUS

---

## Screenshots (PDF)

Click below to view all screenshots:
**[View Screenshots (PDF)](Output_Screenshot.pdf)**

---

## How to Run

1. Clone the repository
2. Open the project in Visual Studio
3. Import SQL tables into Oracle Database
4. Update the connection string in the code
5. Run the project

---

## Author

**Sowmathi R**
Hospital Management System – Mini Project


