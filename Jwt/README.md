# jwt

## In this project, a JWT (JSON Web Token) authentication system was created.

## 1. Creating a User Model
A User class was created. This class has the following properties:

- Id (int, key)

- Email (string, unique)

- Password (string)

## 2. Database Settings
A DbContext class was created using Entity Framework and the User model defined above was added to this class.

## 3. Creating a JWT

An AuthController class was created.

A Login method was written to verify the user's identity. This method received an Email and Password and if the user was a valid user, a JWT was created.

## 4. JWT Validation
The necessary settings were made so that the JWT could be validated in every request. An Authorize attribute was used to validate the JWT in requests.
