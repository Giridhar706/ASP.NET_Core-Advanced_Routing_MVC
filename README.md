# ASP.NET Core Advanced Routing MVC

## Overview

This repository contains two ASP.NET Core MVC applications developed as part of the Wipro NGA .NET Daily Coding Assignments.

The projects demonstrate advanced routing concepts in ASP.NET Core MVC, including:

- Complex Routing
- Dynamic Routing
- Custom Route Constraints
- Route Validation
- User State Based Routing
- MVC Controllers and Views

---

# Projects Included

## Assignment 1 — Advanced Routing MVC

A routing-focused MVC application implementing:

- Complex routing scenarios
- Dynamic routing based on user role
- Custom GUID route constraints
- Multiple controllers and route patterns

### Features

- Product route:
  /Products/{category}/{id}

- User orders route:
  /Users/{username}/Orders

- Dynamic dashboards:
  /Dashboard/admin
  /Dashboard/user

- Custom GUID validation route constraint

---

## Assignment 2 — E-Commerce Routing MVC

An e-commerce MVC application implementing advanced routing techniques.

### Features

- Product details routing
- Product filtering routes
- Dynamic checkout routing
- Login redirection for guest users
- Custom category route constraints

### Routes

- /Products/{category}/{id}

- /Products/Filter/{category}/{priceRange}

- /Checkout

---

# Technologies Used

- ASP.NET Core MVC
- C#
- Razor Views
- Route Attributes
- Custom Route Constraints
- Bootstrap

---

# Folder Structure

aspnetcore-advanced-routing-mvc/
│
├── Assignment1_AdvancedRoutingMVC/
│
│   ├── Controllers/
│   ├── Models/
│   ├── Constraints/
│   ├── Views/
│
├── Assignment2_ECommerceRoutingMVC/
│
│   ├── Controllers/
│   ├── Models/
│   ├── Constraints/
│   ├── Views/
│
└── README.md

---

# How to Run

## Assignment 1

1. Open Assignment1_AdvancedRoutingMVC
2. Build the project
3. Press Ctrl + F5

### Functionalities

- Product Details
- User Orders
- Admin Dashboard
- User Dashboard

---

## Assignment 2

1. Open Assignment2_ECommerceRoutingMVC
2. Build the project
3. Press Ctrl + F5

### Functionalities

- Product Details
- Product Filtering
- Checkout Routing
- Login Redirection

---

# Sample Outputs

## Assignment 1 Output

### Home Page

- Product Details Button
- User Orders Button
- Admin Dashboard Button
- User Dashboard Button

### Product Details

Category: Electronics

Product ID:
11111111-1111-1111-1111-111111111111

Name:
Wireless Headphones

Price:
₹2999

---

## Assignment 2 Output

### Product Details

ID: 1

Category: electronics

Name: Smart Watch

Price:
₹4999

### Checkout

Guest User:
Redirects to Login Page

Logged-in User:
Displays Checkout Page

---

# Concepts Demonstrated

## Complex Routing

Examples:

- /Products/Electronics/1
- /Users/Akanksha/Orders

---

## Dynamic Routing

Different pages based on:

- User role
- Login status

---

## Custom Route Constraints

Implemented:

- GUID validation
- Category validation

---

# Learning Outcomes

- Understanding ASP.NET Core MVC routing
- Creating custom route constraints
- Implementing dynamic routing logic
- Working with controllers and Razor views
- Building maintainable MVC applications

---

# Author

Giridhar Gopal

---

# Assignment Reference

Developed as part of Wipro NGA .NET Cohort Daily Coding Assignments.
