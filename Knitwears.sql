use Knitwears
go


create table Knitwears_Main
(
Knitwears_Main_id int primary key identity(1,1),
Knitwears_Stock_id int,
Knitwears_Plan_id int,
Knitwears_Order_id int,
Knitwears_Recipe_id int,
Knitwears_Product_id int,
)

create table Knitwears_Recipe
(
Knitwears_Recipe_id int primary key identity (1,1),
Knitwears_Recipe_Name nvarchar(50),
Knitwears_Recipe_Ingredients_One nvarchar(50),
Knitwears_Recipe_Ingredients_Two nvarchar(50),
Knitwears_Recipe_Ingredients_Three nvarchar(50),
Knitwears_Recipe_Ingredients_Four nvarchar(50),
)


create table Knitwears_User
(
Knitwears_User_id int primary key identity(1,1),
Knitwears_User_Login nvarchar(50),
Knitwears_User_Password nvarchar(50)
)
create table Knitwears_Stock
(
Knitwears_Stock_id int primary key identity(1,1),
Knitwears_Stock_Name nvarchar(50),
Knitwears_Stock_Feature nvarchar(50),
Knitwears_Stock_Weight nvarchar(50),
Knitwears_Stock_Description nvarchar(50),
Knitwears_Stock_Date nvarchar(50),
Knitwears_Stock_Status nvarchar(50),
)
create table Knitwears_Plan_Main
(
Knitwears_Plan_id int primary key identity(1,1),
Knitwears_Plan_Day_id int,
Knitwears_Plan_Week_id int,
Knitwears_Plan_Month_id int,
)

create table Knitwears_Plan_Day
(
Knitwears_Plan_Day_id int primary key identity(1,1),
Knitwears_Plan_Day_Nomenclature nvarchar(50),
Knitwears_Plan_Day_Date nvarchar(50),
Knitwears_Plan_Day_Volume nvarchar(50),
Knitwears_Plan_Day_Note nvarchar(50),
Knitwears_Plan_Day_Status nvarchar(50),
)

create table Knitwears_Plan_Week
(
Knitwears_Plan_Week_id int primary key identity(1,1),
Knitwears_Plan_Week_Nomenclature nvarchar(50),
Knitwears_Plan_Week_Date nvarchar(50),
Knitwears_Plan_Week_Volume nvarchar(50),
Knitwears_Plan_Week_Note nvarchar(50),
Knitwears_Plan_Week_Status nvarchar(50),
)
create table Knitwears_Plan_Month
(
Knitwears_Plan_Month_id int primary key identity(1,1),
Knitwears_Plan_Month_Nomenclature nvarchar(50),
Knitwears_Plan_Month_Date nvarchar(50),
Knitwears_Plan_Month_Volume nvarchar(50),
Knitwears_Plan_Month_Note nvarchar(50),
Knitwears_Plan_Month_Status nvarchar(50),
)
create table Knitwears_Order
(
Knitwears_Order_id int primary key identity(1,1),
Knitwears_Order_Name nvarchar(50),
Knitwears_Order_Vendor_Code nvarchar(50),
Knitwears_Order_Weight nvarchar(50),
Knitwears_Order_Number_Boxes nvarchar(50),
Knitwears_Order_Date nvarchar(50),
Knitwears_Order_Status nvarchar(50),
)
create table Knitwears_Product
(
Knitwears_Product_id int primary key identity(1,1),
Knitwears_Product_Name nvarchar(50),
Knitwears_Product_Weight nvarchar(50),
Knitwears_Product_Sample nvarchar(50),
Knitwears_Product_Description nvarchar(50),
Knitwears_Product_Date nvarchar(50),
Knitwears_Product_Status nvarchar(50),
)
