CREATE TABLE Должности
(
  Наименование_должности INT NOT NULL,
  Оклад INT NOT NULL,
  Обязанности INT NOT NULL,
  Требования INT NOT NULL,
  Код_должности INT NOT NULL,
  PRIMARY KEY (Код_должности)
);

CREATE TABLE Виды_работ
(
  Код_вида INT NOT NULL,
  _Наименование INT NOT NULL,
  _Описание INT NOT NULL,
  Цена_работы INT NOT NULL,
  PRIMARY KEY (Код_вида)
);

CREATE TABLE Материалы
(
  Код_материала INT NOT NULL,
  Код_вида INT NOT NULL,
  Код_материала_2Код_вида INT NOT NULL,
  Код_материала_3Код_вида INT NOT NULL,
  PRIMARY KEY (Код_материала),
  FOREIGN KEY (Код_вида) REFERENCES Виды_работ(Код_вида),
  FOREIGN KEY (Код_материала_2Код_вида) REFERENCES Виды_работ(Код_вида),
  FOREIGN KEY (Код_материала_3Код_вида) REFERENCES Виды_работ(Код_вида)
);

CREATE TABLE Заказчики
(
  Код_заказчика INT NOT NULL,
  Адрес INT NOT NULL,
  ФИО INT NOT NULL,
  Телефон INT NOT NULL,
  Паспортные_данные INT NOT NULL,
  PRIMARY KEY (Код_заказчика)
);

CREATE TABLE Сотрудники
(
  ФИО INT NOT NULL,
  Возраст INT NOT NULL,
  Пол INT NOT NULL,
  Адрес INT NOT NULL,
  Телефон INT NOT NULL,
  Паспортные_данные INT NOT NULL,
  Код_сотрудника INT NOT NULL,
  Код_должности INT,
  Код_бригада INT NOT NULL,
  PRIMARY KEY (Код_сотрудника),
  FOREIGN KEY (Код_должности) REFERENCES Должности(Код_должности),
  FOREIGN KEY (Код_бригада) REFERENCES Бригада(Код_бригада)
);

CREATE TABLE Бригада
(
  Код_бригада INT NOT NULL,
  Код_сотрудника INT NOT NULL,
  Код_сотрудника_3Код_сотрудника INT NOT NULL,
  PRIMARY KEY (Код_бригада),
  FOREIGN KEY (Код_сотрудника) REFERENCES Сотрудники(Код_сотрудника),
  FOREIGN KEY (Код_сотрудника_3Код_сотрудника) REFERENCES Сотрудники(Код_сотрудника)
);

CREATE TABLE Заказы
(
  Дата_начала INT NOT NULL,
  Стоимость INT NOT NULL,
  Об_оплате INT NOT NULL,
  Отметка_о_завершении INT NOT NULL,
  Дата_окончания INT NOT NULL,
  Код_заказа INT NOT NULL,
  Код_заказчика INT NOT NULL,
  Код_бригада INT,
  Код_вида INT NOT NULL,
  PRIMARY KEY (Код_заказа),
  FOREIGN KEY (Код_заказчика) REFERENCES Заказчики(Код_заказчика),
  FOREIGN KEY (Код_бригада) REFERENCES Бригада(Код_бригада),
  FOREIGN KEY (Код_вида) REFERENCES Виды_работ(Код_вида)
);