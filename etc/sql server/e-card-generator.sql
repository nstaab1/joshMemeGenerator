drop table cards;
drop table card_templates;

create table card_templates
(
	id			int				identity(1,1),
	name		varchar(255)	not null,
	imageName	varchar(255) 	not null,
		
	constraint pk_card_templates primary key (id)
);


create table cards
(
	id			int				identity(1,1),
	template_id	int				not null,
	to_email	varchar(100)	not null,
	to_name		varchar(100)	not null,
	message_one		varchar(100)	not null,
	message_two		varchar(100)	not null,
	from_name	varchar(100)	not null,
	from_email	varchar(100)	not null,

	constraint pk_cards primary key(id),
	constraint fk_cards_card_templates foreign key (template_id) references card_templates(id)
);

create table random_card
(
	random_id			int				identity(1,1),
	template_id	int				not null,
	message_one		varchar(100)	not null,
	message_two		varchar(100)	not null,	
	constraint pk_random_card primary key(random_id),
);


insert into card_templates values ('Astley', 'jtAstley.png');
insert into card_templates values ('Bird', 'jtBird.png');
insert into card_templates values ('Boat', 'jtBoatTemp.png');
insert into card_templates values ('Pretzels', 'jtPretzels.png');
insert into card_templates values ('Funny', 'jtFunny.png');
insert into card_templates values ('Indians', 'jtIndians.png');
insert into card_templates values ('Pitcher', 'jtPitcher.png');

insert into cards values (1, 'john@xyz.com', 'John', 'Message One', 'Message Two', 'Jack', 'jack@abc.com');
insert into random_card values (1, 'bool Gonna', '!GiveYouUp');
