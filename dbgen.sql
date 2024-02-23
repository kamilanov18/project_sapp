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
    password_hash char(64)      not null,
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

