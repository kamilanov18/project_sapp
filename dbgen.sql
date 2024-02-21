use bizlabbg_ican;

# drop table icaks_sapp_foreign_order_table;
# drop table icaks_sapp_statuses;
# drop table icaks_sapp_orders;
# drop table icaks_sapp_users_roles;
# drop table icaks_sapp_roles;
# drop table icaks_sapp_actions;
# drop table icaks_sapp_users;
# drop table icaks_sapp_action_history;

CREATE TABLE `icaks_sapp_foreign_order_table` (
  `id` int auto_increment not null,
  `name` nvarchar(50) not null,
  PRIMARY KEY (`id`)
)ENGINE = MyISAM;

CREATE TABLE `icaks_sapp_statuses` (
  `id` int auto_increment not null,
  `name` nvarchar(50) not null,
  PRIMARY KEY (`id`)
)ENGINE = MyISAM;

CREATE TABLE `icaks_sapp_orders` (
  `id` int auto_increment not null,
  `status_id` int not null,
  `foreign_order_table_id` int not null,
  `foreign_order_id` bigint(20) unsigned not null,
  `is_possible_duplicate` bool not null,
  PRIMARY KEY (`id`),
  FOREIGN KEY (`foreign_order_table_id`) REFERENCES `icaks_sapp_foreign_order_table`(`id`),
  FOREIGN KEY (`foreign_order_id`) REFERENCES `icaks_wc_orders`(`id`),
  FOREIGN KEY (`status_id`) REFERENCES `icaks_sapp_statuses`(`id`)
) ENGINE = MyISAM;

CREATE TABLE `icaks_sapp_roles` (
  `id` int auto_increment not null,
  `name` nvarchar(50) not null,
  PRIMARY KEY (`id`)
)ENGINE = MyISAM;

CREATE TABLE `icaks_sapp_users` (
  `id` int auto_increment not null,
  `first_name` nvarchar(50) not null,
  `last_name` nvarchar(50) not null,
  `email` nvarchar(50) not null,
  `password_hash` char(64) not null,
  `role_id` int not null,
  `wage` decimal(6,2) null,
  PRIMARY KEY (`id`)
)ENGINE = MyISAM;

CREATE TABLE `icaks_sapp_users_roles` (
  `id` int auto_increment not null,
  `role_id` int not null,
  `user_id` int not null,
  PRIMARY KEY (`id`),
  FOREIGN KEY (`role_id`) REFERENCES `icaks_sapp_roles`(`id`),
  FOREIGN KEY (`user_id`) REFERENCES `icaks_sapp_users`(`id`)
)ENGINE = MyISAM;

CREATE TABLE `icaks_sapp_actions` (
  `id` int auto_increment not null,
  `name` nvarchar(50) not null,
  `expense` decimal(6,2) not null,
  PRIMARY KEY (`id`)
)ENGINE = MyISAM;

CREATE TABLE `icaks_sapp_action_history` (
  `id` int auto_increment not null,
  `order_id` int not null,
  `user_id` int not null,
  `action_id` int not null,
  `date` datetime not null,
  PRIMARY KEY (`id`),
  FOREIGN KEY (`user_id`) REFERENCES `icaks_sapp_users`(`id`),
  FOREIGN KEY (`action_id`) REFERENCES `icaks_sapp_actions`(`id`),
  FOREIGN KEY (`order_id`) REFERENCES `icaks_sapp_orders`(`id`)
)ENGINE = MyISAM;