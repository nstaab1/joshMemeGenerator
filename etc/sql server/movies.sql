DROP TABLE movies;

create table movies (
	id  int identity(1,1),
	num_of_copies INT,
	available_copies INT,
	title VARCHAR(50),
	release_date DATETIME,
	constraint pk_movies primary key (id)
);

insert into movies (num_of_copies, available_copies, title, release_date) values (5, 5, 'Footprints on the Moon (Le orme) (Primal Impulse)', '2017-04-22 10:37:18');
insert into movies (num_of_copies, available_copies, title, release_date) values (3, 3, 'The Night That Panicked America', '2017-07-02 17:43:09');
insert into movies (num_of_copies, available_copies, title, release_date) values (5, 5, 'Cosmonaut (Cosmonauta)', '2017-07-14 08:34:37');
insert into movies (num_of_copies, available_copies, title, release_date) values (3, 1, 'Last Night', '2017-07-25 10:55:29');
insert into movies (num_of_copies, available_copies, title, release_date) values (3, 3, 'Repast (Meshi)', '2017-05-14 02:49:19');
insert into movies (num_of_copies, available_copies, title, release_date) values (1, 0, 'Vixen!', '2017-04-20 13:19:49');
insert into movies (num_of_copies, available_copies, title, release_date) values (4, 2, 'Number One with a Bullet', '2016-11-17 20:06:35');
insert into movies (num_of_copies, available_copies, title, release_date) values (5, 4, 'Heaven''s Prisoners', '2016-10-30 07:32:31');
insert into movies (num_of_copies, available_copies, title, release_date) values (4, 4, 'Morsian yllättää', '2017-07-21 15:43:40');
insert into movies (num_of_copies, available_copies, title, release_date) values (4, 4, 'Auntie Mame', '2017-02-26 06:38:58');
insert into movies (num_of_copies, available_copies, title, release_date) values (5, 5, 'Estomago: A Gastronomic Story', '2017-07-19 16:43:32');
insert into movies (num_of_copies, available_copies, title, release_date) values (5, 5, 'Class', '2017-07-28 06:52:13');
insert into movies (num_of_copies, available_copies, title, release_date) values (2, 2, 'Fire and Ice', '2016-11-06 09:46:14');
insert into movies (num_of_copies, available_copies, title, release_date) values (1, 1, 'Wedding Photographer, The (Bröllopsfotografen)', '2017-09-28 08:16:48');
insert into movies (num_of_copies, available_copies, title, release_date) values (1, 1, 'Mexican Hayride', '2017-04-23 03:00:09');
insert into movies (num_of_copies, available_copies, title, release_date) values (1, 0, 'Worthless, The (Arvottomat)', '2017-02-17 03:02:49');
insert into movies (num_of_copies, available_copies, title, release_date) values (10, 3, 'Hours, The', '2017-09-21 04:00:21');
insert into movies (num_of_copies, available_copies, title, release_date) values (5, 5, 'I Accuse', '2016-10-31 04:47:00');
insert into movies (num_of_copies, available_copies, title, release_date) values (4, 4, 'Murmur of the Heart (Le souffle au coeur)', '2017-02-03 23:42:41');
insert into movies (num_of_copies, available_copies, title, release_date) values (5, 5, 'Harriet the Spy', '2017-05-09 22:17:25');
insert into movies (num_of_copies, available_copies, title, release_date) values (5, 5, 'Inbetweeners 2, The', '2016-12-27 06:28:17');
insert into movies (num_of_copies, available_copies, title, release_date) values (2, 2, 'Householder, The (Gharbar)', '2017-09-12 07:04:54');
insert into movies (num_of_copies, available_copies, title, release_date) values (5, 5, 'Tangled Ever After', '2017-06-30 16:10:31');
insert into movies (num_of_copies, available_copies, title, release_date) values (3, 3, 'Remember the Titans', '2017-04-15 05:10:15');
insert into movies (num_of_copies, available_copies, title, release_date) values (5, 5, 'Christmas in July', '2017-08-04 09:56:57');
insert into movies (num_of_copies, available_copies, title, release_date) values (2, 2, 'South, The (Sur, El)', '2016-11-21 10:54:30');
insert into movies (num_of_copies, available_copies, title, release_date) values (1, 1, 'Score: A Hockey Musical', '2017-04-07 19:04:10');
insert into movies (num_of_copies, available_copies, title, release_date) values (1, 1, 'Gift, The', '2017-06-06 23:22:22');
insert into movies (num_of_copies, available_copies, title, release_date) values (1, 0, 'Ainoat Oikeat', '2017-10-11 23:35:06');
insert into movies (num_of_copies, available_copies, title, release_date) values (8, 7, 'Cameron''s Closet', '2017-07-21 05:31:44');
