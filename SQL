--primary key and parent table--

create table employees1
(
EmpID INT PRIMARY KEY,
EmpName VARCHAR(25),
EmpAddress varchar(25)
)

insert into employees1 values(11,'raj','bangalore');
insert into employees1 values(12,'amar','delhi');
insert into employees1 values(13,'saakshi','mangalore');
insert into employees1 values(14,'jeevan','mysore');
insert into employees1 values(15,'sindu','belur');
insert into employees1 values(16,'bindu','mandya');
insert into employees1 values(17,'chaithra','bangalore');

--foreign key and child table--

create table Company
(
CID INT PRIMARY KEY,
CNAME VARCHAR(25),
employees1No INT FOREIGN KEY REFERENCES employees1(EmpId)
)

insert into Company values(101,'infosys',11);
insert into Company values(102,'Wipro',12);
insert into Company values(103,'Datalyzer',13);
insert into Company values(104,'Mphasis',14);
insert into Company values(105,'Mindtree',15);
insert into Company values(106,'Tcs',16);
insert into Company values(107,'Tach mahindra',17);

--REFERENTIAL INTEGRITY--

alter table Company drop constraint FK__Company__employe__59FA5E80 --dropping a foreign key

alter table Company add constraint FK__Company__employe__59FA5E80 foreign key(employees1No) references employees1(EmpID) on delete cascade;

--Delete--

delete from employees1 where EmpId=17

select * from employees1

--Update--

update employees1 set EmpId=18 where EmpId=17

alter table Company drop constraint FK__Company__employe__59FA5E80

update employees1 set EmpId=17 where EmpId=16

--Index-clusterd-non clustered and filtered index--

create table employee2
(
Emp_id INT PRIMARY KEY,
Emp_name VARCHAR(20),
Experience int,
Salary int
)

insert into employee2 values(101,'ram',10,20000);
insert into employee2 values(102,'anand',3,20000);
insert into employee2 values(103,'rani',1,20000);
insert into employee2 values(104,'seetha',5,20000);
insert into employee2 values(105,'ramya',11,20000);

select * from employee2

update employee2 set salary=30000 where Emp_id=101
update employee2 set salary=25000 where Emp_id=102
update employee2 set salary=35000 where Emp_id=103
update employee2 set salary=37000 where Emp_id=104

alter table employee2 drop constraint PK__employee__263E2DD312392F08

--cluster creation--
create clustered index EID on employee2(Emp_id)

select Emp_id from employee2

select * from employee2 where salary>=30000

--Filter index--

create index Emp_salary on employee2(salary) where salary>=30000

--unique non clustered--
create unique nonclustered index Empe_Empname on employee2(Emp_name)

--Sequences--

create sequence dbo.seqemployee2
as int
start with 1
increment by 1

--to view
select * from sys.sequences where name='Seqemployee2'

create table seq_emp
(
eid int primary key,
name varchar(20),
address varchar(20)
)

--for finding next value--

select next value for dbo.Seqemployee2 

insert into seq_emp values(next value for dbo.Seqemployee2,'ram','bangalore')
insert into seq_emp values(next value for dbo.Seqemployee2,'sanvi','mysore')
insert into seq_emp values(next value for dbo.Seqemployee2,'rani Murthy','mangalore')
insert into seq_emp values(next value for dbo.Seqemployee2,'yathish','belgaum')
insert into seq_emp values(next value for dbo.Seqemployee2,'sagar','delhi')

select * from seq_emp 

delete from seq_emp 

--resets the values--

alter sequence Seqemployee2  restart with 1 

--drop the sequence--

drop sequence seqemployee2

--views--
--1.simple views--
--2.complex views--

--simple views--are used for viewing the single table

create view view_employee2salary
as 
select emp_id,emp_name,salary,experience,iif(experience>5,'eligible','not eligible')as promotion from employee2 

select * from View_employee2salary

--complex view--

create view View_empPromotion
as
select e.Emp_id,e.Emp_name,e.experience,c.CID,c.name
from employees1 as e full join Company as c on e.Emp_id=c.CID
full join employee2 as d on c.cID=d.eID

select * from View_empPromotion

--synonyms--

create synonym empl for dbo.employee1

select * from empl 

drop synonym if exists empl

