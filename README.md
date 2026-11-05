# 🚲🍄 Lab 2: Bicycle Rental & Mushroom Identifier

A complete C# Windows Forms application built from scratch for Lab 2. This project demonstrates multi-form navigation, user input validation, error handling, and logic-based decision trees.

## 📸 Screenshots

Here are the screenshots of the working application:

### 1. Login Screen
*(Validates empty inputs before allowing access)*



### 2. Main Menu
*(Navigation hub to access the two lab activities)*
![Main Menu](menu.png)

### 3. Bicycle Rental System
*(Calculates the hourly rate based on the time of day)*
![Bicycle Form](bicycle.png)

### 4. Mushroom Identifier
*(Uses a decision tree to identify the mushroom based on Yes/No questions)*
![Mushroom Form](mushroom.png)

---

## ✨ Features

* **Login Validation:** Prevents users from entering empty usernames or passwords.
* **Form Navigation:** Smooth transitions between Login -> Menu -> Bicycle/Mushroom using `this.Hide()` and `new Form().Show()`.
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

## 🛠️ Built With
* **Language:** C#
* **Framework:** .NET 10.0 (Windows Forms)
* **IDE:** Visual Studio

## 🚀 How to Run This Project
1. Clone this repository to your local machine.
2. Open the `Lab2Project.slnx` file in Visual Studio.
3. Press `F5` or click the green **Start** button to run the application.

---
*Created as part of the .NET Programming Course - Lab 2.*
