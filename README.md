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
![Screenshot (26)](https://user-images.githubusercontent.com/46994774/123090147-b921b200-d41f-11eb-914e-da55314af31e.png)

  * Trello ~ https://trello.com/b/hi9NQoVj
## Risk Assessment
## Testing
## Deployment
Using CI/CD pipelines and github actions to deploy all services and then use URLs to show they have been deployed manually besides frontend*
## Ansible
## Terraform
Used to create azure services - resource group + app services
main.tf created a resource group called CPSFIA2.1 and 4 services on azure.
## Known Issues
Can't push to github so wasn't able to test frontend homeController.
Terraform not deployed but code and .yml files exist

## Reflection

