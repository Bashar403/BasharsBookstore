2023-10-29 1410  Last Modified 2023-11-13

Created an asp.net web app using core 5.0 and named it basharsbook store

1412
Created a git repo and published it

1419
added 2 breakpoints in the controller and got famaliar with the app.

1428
downloaded bootstrap and css files and replaced them with the existing files

1429
edited the styling in layout.schtml

1432
the edited the style in loginpartial to change the color from dark to white 

1436
added aditional stylesheets and scripts

1457
added a dropdown menu to the nav bar 

1509
added three new class libraries and moved Data folder to DataAccess 

1523
istalled packages  Version="5.0.17" 
deleted migration folder

1535 
deleted all classes and edited the name space

1541
moved the models folder to the new project and renamed it and changed the namespace 

1718
modifid the startups and corrected errorviewmodels

1727
added customer area and modified startup and moved the controller file

1734
coppied the viewstart file and pasted in the Custormer area

1740
added admin area and deleted the models and data folders

2023-11-06 Part 2

1106
built the application and confirmed there are no errors

1112 
added new migration to dataaccess with the name 
AddBooksTable

1115
checked the appliction for errors and no problems so far.

1120 
added a Category class and modifiy it 

1143
updated application db and delted old migration and added the new one 

1152 
added IRepo folders and classes and modified it 
added 4 new mothods the Irepo class

1208
updated Repo class 

1321
updated  Category Repository and IcategoryRepo

1347
added IspCall and sp_call and modified both of them 

2113
added Unitofwork and IUnitOfWork and modified 
ran into 2 errors that the UnitOfWork class you are trying to register with dependency injection do not implement the IUnitOfWork interface, also the IUnitOfWork was named wrong.

2128
created a category controller and modified it 

2137
added a new category with an index.cshtml and coppied the code found in the assignment 2 folder

2142 
added a new nav link in the dropdown list to link the Category page

2209
added 2 cshtml creat and edit

2235
update the html and added asp action \

2254
updated the category controller to implement the edit and create

2342
update the category controller to implement the delete function
also added a delete function to javascript.

2023-11-19 
created a Covertype model with the name of covertype.cs and added 2 properties Id and Model

1435
Added ICoverTypeRepository Class that defines the contract for the CoverTypeRepository class. It includes methods for basic CRUD operations on CoverType entities.

1434
updated the CoverTypeRepository mplements the ICoverTypeRepository interface. It contains basic structure for now 

1443
updated the IUnitOfWork and unitofwork to implement CoverType

1449
updated the CoverTypeRepo to implement actual logic for interacting with the database and performing CRUD operations on CoverType entities

1449
fixed 2 errors first i had to make the models class public and eddited the ApplicationDbContext class to define the DbSet property for the CoverType entity also added a using statment to the Covertyperepo to use the models

1508
added Migration to the CoverType 20231119200709_AddCoverType and upadted the database

1512
Updated _Layout.cshtml add a new list item (<li>) with a link (<a>) for "Cover Type"

1521
created the Covertype controller with all required action methods used the previous controller as a templete 

1623 
created the index and upsert for covertypes fix all the errors small problem that when the create button is pressed nothing is happenening will go back to that

1627
added Product.cs in the Models and all the properties with validations

1636
added migration and updated database 20231119213520_AddProductToDb.cs

1645
Updated the Product class so Title, ISBN and Author are [Required], created a new migration (addValidationToProduct) and update the database

1652
Add Product to the Repository and updated it accordinly used the old repos as a template

1654
updated the IUnitOfWork and unitofwork to implement Products build the project nad there are no errors 

1706

added the webhostEnvironment call and the using statment and changed the public product method

1849
installed the rendering packages created the controller and updated the controller 

1924 
created the index in the view and and created the new js file for the product and fixed the controller from any errors 

1954
created an upsertcs for products and used the files from assignment 2 added the textarea using the tinycloud api

1552 2023-11-20
couple of things have been changed my iCover and covertype have been changed to follow the same template as Category, before when i was createing a cover type it was not doing anything becuase by upsert didnt have a post method,
but now i changed so it is posting the item to the data base but not showing it in the index 

1512
fixed the problem not displaying the items it was in my javascript file i had it pointing to the wrong table


2023-11-27
1626: i wll implement the img method to be able to save images we do that by editing the productcontroller

1632: updated the iproductrepo and productrepo to follow the same convintion as category and covertype

1635: updated the Customer homecontroller to work with iunitofwork and add the using statments	

1638: updated the index for customer where he will be able to see the books 