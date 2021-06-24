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

  * Trello ~ https://trello.com/b/hi9NQoVj/sfia-20
![image](https://user-images.githubusercontent.com/46994774/123221312-bb8b1700-d4c6-11eb-902d-c36cb6e1697c.png)
My Trello board contains the following

Pre-Sprint prep- This involves outline the necessary steps taken before the project began.
Epics - these relate to the large amounts of work/tasks which can be broken down.
Product backlog items- are items which can be implement to further improve the application, they are single sources of work which can be completed.
Tasks- involve work that needs to be done in this project that is the 3 objects and frontend applications.
User Stories- explains the end goal of people who interact with the application through an informal explanation of the software features.

## Risk Assessment
![image](https://user-images.githubusercontent.com/46994774/123231720-5f2cf500-d4d0-11eb-8961-096055f0dd86.png)

## Testing
![image](https://user-images.githubusercontent.com/46994774/123221473-e5dcd480-d4c6-11eb-9ec2-f17ae6951c71.png)
Testing allows us to use code that can help us to verify the expected behavior of the other code in the project.
## Deployment
Using CI/CD pipelines and github actions to deploy all services and then use URLs to show they have been deployed manually besides frontend*
![image](https://user-images.githubusercontent.com/46994774/123222020-70bdcf00-d4c7-11eb-9c8f-61a242e965f4.png)
http://cp1-web-luckystars.azurewebsites.net/
![image](https://user-images.githubusercontent.com/46994774/123222071-7b786400-d4c7-11eb-9cc4-bfc6e871c7ea.png)
http://cp1-web-numbers.azurewebsites.net/
![Screenshot (39)](https://user-images.githubusercontent.com/46994774/123222130-88955300-d4c7-11eb-832c-ec23a0aa2e85.png)
http://cp1-web-frontend.azurewebsites.net/
![Screenshot (40)](https://user-images.githubusercontent.com/46994774/123222161-8fbc6100-d4c7-11eb-85fc-7a7979bc83b7.png)
http://cp1-web-merge.azurewebsites.net/
## Terraform
Used to create azure services - resource group + app services
main.tf created a resource group called CPSFIA2.2 and 4 services on azure.
## Known Issues
Frontend test doesn't pass due to not being able to retrieve a value for numbers.
No fully test report carried out
Not fully functioning and only redeploying manually after terraform is applied main.yml not applied

## Reflection
Learnt a lot along the way whilst doing the project. Saw how the different areas of training can be implemented into a project. Used lots of new software for the first time and had to adapt and learn more about these softwares during my project.
