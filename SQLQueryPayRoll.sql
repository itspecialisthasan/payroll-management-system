create table tbl_department(
dept_id int identity (1,1) not null,
dept_name varchar(50) not null,
dept_strenght varchar(50) not null,
dept_otrates varchar(50) not null,
unit_id int null

constraint PK_DEPT_ID primary key (dept_id),
constraint FK_UNIT_ID foreign key (unit_id) references tbl_millUnit (unit_id)

on delete cascade
on update cascade
);



create table tbl_subdepartment(
sdept_id int identity (1,1) not null,
sdept_name varchar(50) not null,
sdept_strenght varchar(50) not null,
dept_id int null

constraint PK_SDEPT_ID primary key (sdept_id),
constraint FK_DEPT_ID foreign key (dept_id) references tbl_department (dept_id)

on delete cascade
on update cascade
);

create table tbl_designation(
desig_id int identity (1,1) not null,
desig_name varchar(50) not null,

constraint PK_DESIG_ID primary key (desig_id),
);

create table tbl_reasons(

reason_id int identity (1,1) not null,
reason_name varchar(50) not null

constraint PK_REASON_ID primary key (reason_id),
);


create table tbl_timingGroup(

tg_id int identity (1,1) not null,
tg_name varchar(50) not null,
tg_shifttype varchar(50) not null,

constraint PK_TIMINGGROUP_ID primary key (tg_id)

);

create table tbl_religion(

religion_id int identity (1,1) not null,
religion_name varchar(50) not null,

constraint PK_RELIGION_ID primary key (religion_id)

);

create table tbl_nationality(

nationality_id int identity(1,1) not null,
nationality_name varchar(50) not null,

constraint PK_NATIONALITY_ID primary key (nationality_id)

);

create table tbl_bankdetails(

bank_id int identity (1,1) not null,
bank_name varchar(50) not null,
branch_name varchar(50) not null,
branch_code int not null,
address varchar(50) not null,
country varchar(50) not null,
currency varchar(50) not null

constraint PK_BANK_ID primary key (bank_id),

);

create table tbl_terminal(

terminal_id int identity (1,1) not null,
terminal_name varchar(50) not null,

constraint PK_TERMINAL_ID primary key (terminal_id)

);

create table tbl_healthinsurance(

health_id int identity (1,1) not null,
health_plan_name varchar(50) not null,
health_plan_amount varchar(50) not null,

constraint PK_HEALTH_ID primary key (health_id)

);

create table tbl_vehicledetention(

veh_id int identity (1,1) not null,
veh_type_name varchar(50) not null,
veh_type_amount varchar(50) not null,

constraint PK_VEHICLE_ID primary key (veh_id)

);

create table tbl_employee(

emp_id int identity (1,1) not null,
emp_name varchar(50) not null,
emp_father_name varchar(50) not null,

emp_address varchar(50) not null,
emp_email varchar(50) not null,
emp_mobile_no int not null,
emp_nic int not null,
nationality_id int,
emp_dob date,
emp_age int not null,
emp_martial_status varchar(50) not null,
religion_id int,
emp_gender varchar(50) not null,
unit_id int,
dept_id int,
sdept_id int,
desig_id int,
tg_id int,
emp_type varchar(50) not null,
emp_appt_date date,
emp_salary int not null,
emp_wage_cat varchar(50) not null,
time_id int,
emp_restday varchar(50) not null,
emp_reportto varchar(50) not null,
emp_contract_service varchar(50) not null,
emp_ot varchar(50) not null,
emp_onshift varchar(50) not null,
emp_colony varchar(50) not null,
emp_inst_type varchar(50) not null,
emp_inst_title varchar(50) not null,
emp_inst_name varchar(50) not null,
emp_inst_passing_g varchar(50) not null,
emp_inst_passing_yr varchar(50) not null,
emp_last_company varchar(50) not null,
emp_last_position varchar(50) not null,
emp_experince varchar(50) not null,
emp_last_salary varchar(50) not null,
health_id int,
veh_id int,
emp_incometax varchar(50) not null,
emp_ntn_no varchar(50) not null,
emp_eobi_no varchar(50) not null,
emp_sessi_no varchar(50) not null,
emp_gi_no varchar(50) not null,
emp_graduity varchar(50) not null,
emp_pf varchar(50) not null,

emp_ref_no int,
emp_ref_name varchar(50) not null,
emp_ref_mob int not null,
emp_ref_email varchar(50) not null,

bank_id int,
emp_acct_no varchar(50) not null,
emp_acct_name varchar(50) not null,
emp_iban_no varchar(50) not null


constraint PK_EMPLOYEE_ID primary key (emp_id),
constraint FK_MUNIT_ID foreign key (unit_id) references tbl_millUnit (unit_id),
constraint FK_DEPART_ID foreign key (dept_id) references tbl_department (dept_id),
constraint FK_SDEPARTT_ID foreign key (sdept_id) references tbl_subdepartment (sdept_id),
constraint FK_NATIONALITY_ID foreign key (nationality_id) references tbl_nationality (nationality_id),
constraint FK_DESIGNATION_ID foreign key (desig_id) references tbl_designation (desig_id),
constraint FK_TIMINGGROUP_ID foreign key (tg_id) references tbl_timingGroup (tg_id),
constraint FK_TIMING_ID foreign key (time_id) references tbl_timing (time_id),
constraint FK_HEALTH_ID foreign key (health_id) references tbl_healthinsurance (health_id),
constraint FK_vehicle_ID foreign key (veh_id) references tbl_vehicledetention (veh_id)

on delete cascade
on update cascade
);


create table tbl_user(

userid int identity (1,1) not null,
username varchar(50) not null,
pasword varchar(50) not null,
role varchar(20) not null

constraint PK_USER_ID primary key (userid)

);