# SFIA
# Lucky Stars App

## Table of Contents
## Expectations of the Project
Create an application that generate objects upon a set of predefined rules. The project must contain 3 random objects which is supported by the frontend. Each of the 3 random objects have specific roles. Object one is used to output a random single digit number between 1-10. Object two contains 13 Lucky stars where the rules alow 1 random luckyStar to be outputted. Object 3 involves a merger between object 1 and 2 resulting a random digit between 1-10 and 1 of 13 Luckystars being output. This is all then supported by the frontend API which displays combo of a number and Luckystar.
## My Approach
Use an array for object 1 and 2.
Object 1
Contains an array for number 1-10 where a predefined rule is used to draw a random digit from within the array.
Object 2
Contains a string array with all 13 LuckyStars contain within the array and a random star is drawn from the rules within the class.
Object 3
The main purpose of this object is to communicate with object 1 and 2. This is proven by how object 3 returns a random digit from the int array and a random string from the string array defined in object 2.
FrontEnd.
This is the core service and communicates with the 3 other objects.
## Architecture
  * ERD
  * Balsamiq
  * Use Case
  * Trello ~ https://trello.com/b/hi9NQoVj
## Risk Assessment
## Testing
## Deployment
Using CI/CD pipelines and Azure app dev
## Ansible
## Terraform
## Known Issues
## Reflection

