use bizlabbg_ican;

create table icaks_sapp_action_history
(
    id        int auto_increment
        primary key,
    order_id  int      not null,
    user_id   int      not null,
    action_id int      not null,
    date      datetime not null
)
    engine = MyISAM;

create index action_id
    on icaks_sapp_action_history (action_id);

create index order_id
    on icaks_sapp_action_history (order_id);

create index user_id
    on icaks_sapp_action_history (user_id);

create table icaks_sapp_actions
(
    id      int auto_increment
        primary key,
    name    varchar(50)   not null,
    expense decimal(6, 2) not null
)
    engine = MyISAM;

create table icaks_sapp_foreign_order_table
(
    id   int auto_increment
        primary key,
    name varchar(50) not null
)
    engine = MyISAM;

create table icaks_sapp_orders
(
    id                     int auto_increment
        primary key,
    status_id              int             not null,
    foreign_order_table_id int             not null,
    foreign_order_id       bigint unsigned not null,
    is_possible_duplicate  tinyint(1)      not null
)
    engine = MyISAM;

create index foreign_order_id
    on icaks_sapp_orders (foreign_order_id);

create index foreign_order_table_id
    on icaks_sapp_orders (foreign_order_table_id);

create index status_id
    on icaks_sapp_orders (status_id);

create table icaks_sapp_roles
(
    id   int auto_increment
        primary key,
    name varchar(50) not null
)
    engine = MyISAM;

create table icaks_sapp_statuses
(
    id   int auto_increment
        primary key,
    name varchar(50) not null
)
    engine = MyISAM;

create table icaks_sapp_users
(
    id            int auto_increment
        primary key,
    first_name    varchar(50)   not null,
    last_name     varchar(50)   not null,
    email         varchar(50)   not null,
    password_hash char(64)      null,
    wage          decimal(6, 2) null
)
    engine = MyISAM;

create table icaks_sapp_users_roles
(
    id      int auto_increment
        primary key,
    role_id int not null,
    user_id int not null
)
    engine = MyISAM;

create index role_id
    on icaks_sapp_users_roles (role_id);

create index user_id
    on icaks_sapp_users_roles (user_id);


alter table icaks_sapp_users
add column phone varchar(10) not null

insert into icaks_sapp_users (first_name, last_name, email, password_hash) VALUE ('a','a','a@a','123')

update icaks_sapp_users
set phone = '0887769203'
where id=1

insert into icaks_sapp_users_roles (role_id, user_id) VALUE (1,1)

desc icaks_sapp_users;

select * from icaks_wc_orders

desc icaks_wc_orders;
desc icaks_wc_order_addresses;
desc icaks_wc_order_product_lookup;
desc icaks_wc_customer_lookup;
desc bizlabbg_ican.icaks_wc_product_meta_lookup;

select
    o.id,
    a.first_name,
    a.last_name,
    a.email,
    a.address_1,
    a.address_2,
    a.city,
    a.state,
    a.postcode,
    a.country,
    a.phone,
    mp.sku as product_name,
    lp.product_qty
from icaks_wc_orders o
join icaks_wc_order_addresses a on a.order_id=o.id
join icaks_wc_order_product_lookup lp on lp.order_id = o.id
join icaks_wc_product_meta_lookup mp on mp.product_id = lp.product_id
join icaks_wc_customer_lookup lc on lc.customer_id = lp.customer_id
where a.address_type = 'shipping'
AND o.id=1311