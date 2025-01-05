CREATE TABLE [User] (
  [id] int IDENTITY(1,1) NOT NULL UNIQUE,
  [email] nvarchar(128) NOT NULL UNIQUE,
  [fio] nvarchar(128) NOT NULL,
  [login] nvarchar(64) NOT NULL UNIQUE,
  [password] nvarchar(256) NOT NULL,
  [role] nvarchar(64) NOT NULL,
  PRIMARY KEY ([id])
);

CREATE TABLE [User_group] (
  [group] int NOT NULL UNIQUE,
  [user] int NOT NULL UNIQUE,
  PRIMARY KEY ([group], [user])
);

CREATE TABLE [Group] (
  [id] int IDENTITY(1,1) NOT NULL UNIQUE,
  [name] nvarchar(64) NOT NULL,
  PRIMARY KEY ([id])
);

CREATE TABLE [Shedule] (
  [id] int IDENTITY(1,1) NOT NULL UNIQUE,
  [group] int NOT NULL,
  [user] int NOT NULL,
  [room] int NOT NULL,
  [schedule_date_] date NOT NULL,
  [schedule_object] int NOT NULL,
  PRIMARY KEY ([id])
);

CREATE TABLE [Room] (
  [id] int IDENTITY(1,1) NOT NULL UNIQUE,
  [name] nvarchar(64) NOT NULL,
  PRIMARY KEY ([id])
);

CREATE TABLE [Schedule_object] (
  [id] int IDENTITY(1,1) NOT NULL UNIQUE,
  [name] nvarchar(64) NOT NULL,
  PRIMARY KEY ([id])
);


ALTER TABLE [User_group] ADD CONSTRAINT [user_group_fk0] FOREIGN KEY ([group]) REFERENCES [Group]([id]);

ALTER TABLE [User_group] ADD CONSTRAINT [user_group_fk1] FOREIGN KEY ([user]) REFERENCES [User]([id]);

ALTER TABLE [Shedule] ADD CONSTRAINT [shedule_fk1] FOREIGN KEY ([group]) REFERENCES [Group]([id]);

ALTER TABLE [Shedule] ADD CONSTRAINT [shedule_fk2] FOREIGN KEY ([user]) REFERENCES [User]([id]);

ALTER TABLE [Shedule] ADD CONSTRAINT [shedule_fk3] FOREIGN KEY ([room]) REFERENCES [Room]([id]);

ALTER TABLE [Shedule] ADD CONSTRAINT [shedule_fk5] FOREIGN KEY ([schedule_object]) REFERENCES [schedule_object]([id]);