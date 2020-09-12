CREATE TABLE Сотрудники
(
  ФИО VARCHAR NOT NULL,
  Возраст INT NOT NULL,
  Пол CHAR NOT NULL,
  Адрес VARCHAR NOT NULL,
  Телефон VARCHAR NOT NULL,
  Паспортные_данные VARCHAR NOT NULL,
  Код_сотрудника INT NOT NULL,
  PRIMARY KEY (Код_сотрудника)
);

CREATE TABLE Должности
(
  Наименование_должности VARCHAR NOT NULL,
  Оклад INT NOT NULL,
  Обязанности VARCHAR NOT NULL,
  Требования VARCHAR NOT NULL,
  Код_должности INT NOT NULL,
  PRIMARY KEY (Код_должности)
);

CREATE TABLE Виды_работ
(
  Код_вида INT NOT NULL,
  _Наименование VARCHAR NOT NULL,
  _Описание VARCHAR NOT NULL,
  Цена_работы INT NOT NULL,
  PRIMARY KEY (Код_вида)
);

CREATE TABLE Материалы
(
  Код_материала INT NOT NULL,
  PRIMARY KEY (Код_материала)
);

CREATE TABLE Бригада
(
  Код_бригада INT NOT NULL,
  PRIMARY KEY (Код_бригада)
);

CREATE TABLE Заказчики
(
  Код_заказчика INT NOT NULL,
  Адрес VARCHAR NOT NULL,
  ФИО VARCHAR NOT NULL,
  Телефон VARCHAR NOT NULL,
  Паспортные_данные VARCHAR NOT NULL,
  PRIMARY KEY (Код_заказчика)
);

CREATE TABLE Заказы
(
  Дата_начала DATE NOT NULL,
  Стоимость INT NOT NULL,
  Об_оплате VARCHAR NOT NULL,
  Отметка_о_завершении VARCHAR NOT NULL,
  Дата_окончания DATE NOT NULL,
  Код_заказа INT NOT NULL,
  PRIMARY KEY (Код_заказа)
);