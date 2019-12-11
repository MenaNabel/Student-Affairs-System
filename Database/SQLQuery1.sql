create database Student_Affairs_System
use Student_Affairs_System
create table course(
course_code varchar(10) unique not null,
course_name nvarchar(255) not null,
course_level int not null,
course_semester int not null,
doctor_name nvarchar not null,
course_hours int not null,
primary key(course_code)
);

create table student_case_report(
ID int IDENTITY(1,1),
student_ID varchar(10) not null,
course_ID varchar(10) not null,
total_degree decimal ,
student_age int not null,
primary key(ID),
foreign key(student_ID) references student(student_ID) ON DELETE CASCADE ON UPDATE CASCADE,
foreign key(course_ID) references course(course_code) ON DELETE CASCADE ON UPDATE CASCADE,
);

create table student_available_course(
ID int IDENTITY(1,1),
student_ID varchar(10) not null,
course_ID varchar(10) not null,
foreign key(student_ID) references student(student_ID) ON DELETE CASCADE ON UPDATE CASCADE,
foreign key(course_ID) references course(course_code) ON DELETE CASCADE ON UPDATE CASCADE,
);

create table student_degree(
ID int IDENTITY(1,1),
student_ID varchar(10) not null,
course_ID varchar(10) not null,
activites decimal ,
practical decimal ,
foreign key(student_ID) references student(student_ID) ON DELETE CASCADE ON UPDATE CASCADE,
foreign key(course_ID) references course(course_code) ON DELETE CASCADE ON UPDATE CASCADE,
);

create table prequest_course(
ID int IDENTITY(1,1),
pre_ID varchar(10) not null,
course_ID varchar(10) not null,
foreign key(pre_ID) references course(course_code) ,
foreign key(course_ID) references course(course_code) ON DELETE CASCADE ON UPDATE CASCADE,
);


create table student(
student_ID varchar(10) unique not null,
student_name nvarchar(255) not null,
student_national_ID varchar(255) unique not null,
student_level int not null,
student_age int not null,
student_phone varchar(11),
student_adress varchar(255),
primary key(student_ID)
);

create table admin_student(
ID int IDENTITY(1,1),
student_ID varchar(10),
administration_staff_ID int,
foreign key(student_ID) references student(student_ID) ON DELETE CASCADE ON UPDATE CASCADE,
foreign key(administration_staff_ID) references administration_staff(administration_staff_ID) ON DELETE CASCADE ON UPDATE CASCADE,
);

create table administration_staff(
administration_staff_ID int IDENTITY(1,1),
administration_staff_name nvarchar(255) not null,
administration_staff_national_ID varchar(255) unique not null,
administration_staff_password varchar(255) not null,
primary key(administration_staff_ID)
);


ALTER table student_case_report add GPA decimal not null

Alter table client add password nvarchar(MAX)
ALTER table package add start_date date 
ALTER table package add end_date date 
ALTER table package alter column start_date date not null
ALTER table package alter column end_date date not null
Alter table package add available bit
Alter table package alter column available bit not null

Alter table reservation_car add number int IDENTITY(1,1)   not null 
Alter table reservation_car add primary key(number) 
Alter table reservation_car alter column client_ID nvarchar(14)  not null
Alter table reservation_car add foreign key(client_ID) references client(ssna)
Alter table reservation_car add primary key(number) 
Alter table reservation_car add type_reservation nvarchar(255)
alter table reservation_car add package bit
alter table reservation_car add duration int
alter table reservation_car add price decimal
alter table reservation_car add package_ID int
alter table reservation_car add foreign key(package_ID) references package(ID)


INSERT INTO car (num,air_conditioning,available,num_seats,type_car,price,col,pick) VALUES ('A B C 1 2 3',1,0,5,'BMW',100,'Black','E:\Projects\ITI projects\Sno7y\imgs\BMW1.jpg')
INSERT INTO type_client (type_ID,type_name) VALUES (1,'business')
INSERT INTO type_client (type_ID,type_name) VALUES (2,'For fun')
INSERT INTO type_client (type_ID,type_name) VALUES (3,'wedding party')
INSERT INTO client (ssna,name,ID_car,startDate,endDate,t_ID) VALUES (219,'Mena Nabel',100,2019-08-03 ,2019-08-04 ,1)
INSERT INTO client (ssna,name,ID_car,startDate,endDate,t_ID) VALUES (29,'Mena Nabel',100,2019-08-03 ,2019-08-04 ,1)
INSERT INTO client (ssna,name,ID_car,startDate,endDate,t_ID) VALUES (2910,'Kero',100,2019-08-03  ,2019-08-04 ,1)
INSERT INTO client (ssna,name,ID_car,startDate,endDate,t_ID) VALUES (12345678912329,'Mena Nabel',100,2019-08-03 ,2019-08-04 ,1)
Insert INto reservation_car (car_ID, start_Date,end_date,number) values (1,2019-08-03,2019-08-03,1)
delete from car
select CID, package.name  , package.price from car
join package_car on car.CID = package_car.car_ID
join package on package.ID = package_car.package_ID