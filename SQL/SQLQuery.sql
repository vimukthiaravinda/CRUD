use estate_db
create table users (user_id int identity(1,1) not null, first_name varchar(30),last_name varchar(20),email varchar(25),password varchar(20),
address varchar(30),country varchar(15),gender char);

insert into estate_db.dbo.users(first_name,last_name,email,password,address,country,gender) values('vimukthi','aravinda','vimukthi@gmail',
'vim181920','300/2 godauda','srilanka','m');

select * from users

alter table users alter column email varchar(50)

update estate_db.dbo.users set email = 'vimukthiaravinda18@gmail.com' where user_id = 5;

