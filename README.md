# Hospital Management System (HMS)

[GitHub Repository](https://github.com/sowmathi761/HMS.git)

A simple **Windows Form Application** built using **VB.NET** and **Oracle Database** to manage patients, doctors, and appointments.

## Output Screenshots

The screenshots below show the **actual output of the application**:
**[View Output Screenshots (PDF)](Output_Screenshot.pdf)**

## Overview

This project is designed to help manage a hospital’s daily operations including patient records, doctor details, and appointment scheduling.
It features a clean and simple interface with easy navigation between forms.

## Features

* Add, update, delete **Patients**
* Add, update, delete **Doctors**
* Create and manage **Appointments**
* Connects to **Oracle Database**
* Clean and user-friendly interface
* Navigation menu for easy movement between forms

## Technologies Used

* **VB.NET (Windows Forms)**
* **Visual Studio**
* **Oracle Database**
* **SQL Developer**

## Project Structure

* `Form1.vb` → Navigation panel
* `PatientsForm.vb` → Patient CRUD operations
* `DoctorsForm.vb` → Doctor CRUD operations
* `AppointmentsForm.vb` → Appointment CRUD operations
* Oracle SQL queries included

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

## How to Run

1. Clone the repository:

   ```bash
   git clone https://github.com/sowmathi761/HMS.git
   ```
2. Open the project in **Visual Studio**
3. Import SQL tables into **Oracle Database**
4. Update the connection string in the code
5. Run the project

---


