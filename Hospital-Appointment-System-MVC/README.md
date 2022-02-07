# Hospital-Appointment-System-MVC-Project
*ASP.NET database management system project that has MVC structure with using MSSQL*

*The project is developed on Visual Studio.*

About Project
There are generally three main users in the project. These are admin, doctor and patient.
The three main users have their own actions.
These are the ability to get information about doctors, to make an appointment, to
communicate with the doctor and to make evaluations in general for the patient.
For doctors, these abilities to arrange appointments and communicate with the patient.
Admin is the administrator of the site. It is in a position to view all patient and doctor
information and list appointments. In addition, the admin can add doctors to the site. In this
way, doctor entrance checks are made. However, adding a patient can only happen when
the patient becomes a member.
The application (web site) uses Asp.net as a front-end and SQL database as the backend.

**Functionality**

**Patient side functionality:**
- Sign up
- Sign in
- Book appointment
- List/search appointments
- Cancellation appointment
- Feedback
- Contact with doctor (messaging)
- List messages

**Doctor side functionality:**
- Sign up 
- Sign in
- List/search patients
- List/search appointments
- Organization book appointment
- List of all book appointments
- List feedbacks
- Contact with patient (messaging)
- List messages

**Admin side functionality:**
- View user data (patient and doctor)
- View feedbacks
- View appointments
- Add doctor and information

Doctor, patient, admin, appointment, evaluation (feedback), and message are entities for this project.