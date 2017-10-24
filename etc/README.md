# Web Projects

You'll be working on an individual project that will give you the opportunity to practice and re-apply (with some of your own creativity) the concepts that you've learned in the past two weeks. Over these two days your goal will be to get some form of an MVP (minimum viable product) working. After the MVP is working, then you can take the opportunity to improve it and enhance it however you see fit.

Additionally, you'll learn the necessary information to deploy this project so that it is live on a public web server and not running on your computer. Using this you'll be able to build any of your own MVC projects and deploy them.

**NOTE:** Please delete scripts you won't need or use before pushing.


## Online Store

**MVP Requirements**

* As a user I can visit the home page and see product categories the store sells.
    * Example product categories include (kitchen, electronic, clothing, sports)
    * Each category has a title and a main image that goes with it
* As a user I can click on a product category, I am taken to a page where I see the products listed in that category.
    * Items that are hot-sellers (# sold in the past month exceeds > 100) should be indicated to the user
    * Items that are top-rated (avg. rating exceeds 4.0 out of 5.0) should be indicated to the user
* As a user I can click on a product, I am taken to a page where I can see the full details for a product

**Extra Ideas**

* As a user, I can search for a product by name so that I don't have to navigate through the categories.

## E-Card Generator

**MVP Requirements**

* As a user I can visit the home page and see a list of greeting card templates.
    * A greeting card template is a simple background image.
* As a user, I can click on a greeting card template and be prompted to fill out a greeting card.
    * A greeting card message includes a recipient e-mail, recipient name, message, from name, and from e-mail.    
* When I fill out the greeting card, I see my message overlaid on top of the greeting card template.

**Extra Ideas**

* As a user, I can visit a link that is generated when the greeting card is created to see it again.

## Freelance Time Card Tracker

**MVP Requirements**

* As a user, when I visit the home page I am prompted for my e-mail address so that I can view my timecard.
    * This system does not require any passwords.
* As a user, when I enter my e-mail address, I have the option to clock-in or clock-out.
    * When I clock-in, a record is added to the database with my e-mail address and the clock-in time.
    * When I clock-out, the record created in the database when I clocked-in is updated with the clock-out time.
    * When I clock-out, I have the ability to add misc. notes indicating what I worked on.
* As a user, I can see my time-card history so that I can use it to bill my client for projects.    

**Extra Ideas**

* As a user, I can clock-in and clock-out multiple times in one day if I need to take a break or work on different projects.

## Movie Rentals

**MVP Requirements**

* As a user, when I visit the home page, I can click a link to view the list of all movies.
    * The user sees the title, release date.
    * If the movie is out of stock (0 rentals remaining) then this is indicated to the user.
* As a user, I can click on any movie to be taken to a detail page to see more information about the movie.
* As a user, if I want to watch any movie, I can "check-out" the movie.
    * Checking-out the movie deducts the number of rentals in stock by one.
* As a user, when I am ready to return a movie, I can "check-in" a movie.
    * Checking-in increments the number of rentals by one.

**Extra Ideas**

* As a user, when I visit the home page, I see a list of the 5 recently added movies.