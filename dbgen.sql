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
    o.status,
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
where a.address_type = 'shipping';
# AND o.id=3642

select * from icaks_wc_orders
# where id=863

select * from icaks_wc_product_meta_lookup
desc icaks_wc_product_meta_lookup

select distinct status
from icaks_wc_orders;

select * from icaks_sapp_statuses;

select * from icaks_sapp_orders
    where is_possible_duplicate = 1

truncate table icaks_sapp_users;
truncate table icaks_sapp_action_history;
truncate table icaks_sapp_users_roles;
truncate table icaks_sapp_roles;
truncate table icaks_sapp_orders;
truncate table icaks_sapp_actions;
truncate table icaks_sapp_statuses;
truncate table icaks_sapp_foreign_order_table;
truncate table icaks_sapp_orders_econt;

create trigger if not exists is_entry_duplicate
after insert
on icaks_wc_order_addresses
for each row
BEGIN
    insert into icaks_sapp_orders (status_id, foreign_order_table_id, foreign_order_id, is_possible_duplicate) VALUE
    (1,1,NEW.order_id, (
        (select count(*)
        from
            (
            select distinct
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
                join icaks_wc_order_addresses a on a.order_id=NEW.order_id
                join icaks_wc_order_product_lookup lp on lp.order_id = o.id
                join icaks_wc_product_meta_lookup mp on mp.product_id = lp.product_id
                join icaks_wc_customer_lookup lc on lc.customer_id = lp.customer_id
                where a.address_type = 'shipping'
            INTERSECT
            select
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
            ) as result)>1)
    );
END;

select * from icaks_sapp_users

create table icaks_sapp_products (
    id int not null primary key,
    product_id bigint not null,
    weight decimal(8,2),
    FOREIGN KEY (product_id) REFERENCES bizlabbg_ican.icaks_wc_product_meta_lookup(product_id)
) engine = MyISAM;

create table icaks_sapp_orders_econt (
    id int not null primary key,
    order_id int not null,
    shipment_number varchar(100),
    FOREIGN KEY (order_id) REFERENCES  icaks_sapp_orders(id)
) engine = MyISAM;

CREATE TABLE icaks_sapp_econt_clients (
    id int not null primary key,
    name char(100) not null
) engine=MyISAM;

CREATE TABLE icaks_sapp_econt_phones (
    id int not null primary key,
    phone char(20) not null,
    client_id int not null,
    FOREIGN KEY (client_id) REFERENCES icaks_sapp_econt_clients(id)
) engine = MyISAM;

create table icaks_sapp_econt_countries(
    code3 char(3) not null primary key,
    code2 char(2)
) engine =MyISAM;

create  table icaks_sapp_econt_cities(
    id int not null,
    name varchar(50) not null,
    post_code char(6) not null,
    country_code char(3) not null,
    FOREIGN KEY (country_code) REFERENCES icaks_sapp_econt_countries(code3)
) engine = MyISAM;

drop table icaks_sapp_econt_addresses;

create table icaks_sapp_econt_addresses (
    id int not null primary key,
    city_id int not null,
    street char(100) not null,
    fullAddress varchar(200),
    num char(5),
    other char(100),
    quarter char(50),
    zip char(10),
    FOREIGN KEY (city_id) REFERENCES icaks_sapp_econt_cities(id)
) engine = MyISAM

desc icaks_sapp_econt_countries;

alter table icaks_sapp_econt_countries
add column name char(50) not null;

create table icaks_sapp_econt_orders (
    id int not null,
    order_id int not null,
    client_id int not null,
    address_id int not null,
    shipment_number char(100),
    foreign key (order_id) references icaks_sapp_orders(id),
    foreign key (client_id) references  icaks_sapp_econt_clients(id),
    foreign key (address_id) references  icaks_sapp_econt_addresses(id)
) ENGINE = MyISAM