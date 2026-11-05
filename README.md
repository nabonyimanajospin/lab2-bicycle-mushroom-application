# Lab 2: Bicycle Rental & Mushroom Identifier

A complete C# Windows Forms application built from scratch for Lab 2. This project demonstrates multi-form navigation, user input validation, error handling, and logic-based decision trees.

**Course Lecturer:** Adonia Ndagijimana
**Student ID:** 26511

## Screenshots

Here are the screenshots of the working application:

### 1. Login Screen
*(Validates empty inputs before allowing access)*
<img width="903" height="488" alt="image (2)" src="https://github.com/user-attachments/assets/8d652b6b-9dcf-44e1-9dd4-5e991c58377c" />

### 2. Main Menu
*(Navigation hub to access the two lab activities)*
<img width="802" height="484" alt="image (3)" src="https://github.com/user-attachments/assets/aa69d3c1-0b7c-4d76-8cf7-c06df9521a58" />

### 3. Bicycle Rental System
*(Calculates the hourly rate based on the time of day)*
<img width="803" height="485" alt="image (4)" src="https://github.com/user-attachments/assets/a980466b-24ab-4737-a3f3-b896dccbac3b" />

### 4. Mushroom Identifier
*(Uses a decision tree to identify the mushroom based on Yes/No questions)*
<img width="803" height="487" alt="image" src="https://github.com/user-attachments/assets/bbce8fac-ca7b-4863-bb3f-bf6a12c8fc41" />

---

## Features

* **Login Validation:** Prevents users from entering empty usernames or passwords.
* **Form Navigation:** Smooth transitions between Login, Menu, Bicycle, and Mushroom forms using `this.Hide()` and `new Form().Show()`.
* **Bicycle Rental Logic:**
  * Hour-by-hour `while` loop calculation to handle cross-over rates.
  * Error handling using `int.TryParse` to prevent crashes if the user types letters instead of numbers.
  * Validates that Start Time is between 0-23 and End Time is between 1-24.
* **Mushroom Logic Tree:**
  * Uses RadioButtons inside GroupBoxes so users can only select one answer per question.
  * Requires specific answers before finalizing (e.g., if Forest=Yes and Cup=Yes, it requires the Ring question).
  * Automatically clears all radio buttons after a result is shown, ready for the next user.
* **User Experience (UX):** Clears text boxes and resets focus after calculations to make typing new inputs faster.

---

## Built With
* **Language:** C#
* **Framework:** .NET 10.0 (Windows Forms)
* **IDE:** Visual Studio

## How to Run This Project
1. Clone this repository to your local machine.
2. Open the `Lab2Project.slnx` file in Visual Studio.
3. Press `F5` or click the green **Start** button to run the application.

---
*Created as part of the .NET Programming Course - Lab 2.*
