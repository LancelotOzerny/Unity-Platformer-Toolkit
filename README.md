# Unity Platformer Toolkit (U.P.T.)

# Предназначение модуля

Модуль Unity Platformer Toolkit предоставляет разработчикам Unity-проектов решение множества рутинных задач, таких как:
1) unit-система, которая позволяет создать персонажа для игрока и npc-персонажей за считанные минуты;
2)  и другое.


# Система юнитов
Система юнитов позволяет реализовать персонажей в считанные минуты.
Ниже разберем классы, которые используются в персонажах:

## Столкновение с коллайдерами заданных слоев или создание прыжка

- LayerContactChecker -- это базовый, абстрактный класс для создания проверки столкновения со слоями. Наследники данного класса позволяют проверить, находится ли персонаж на расстоянии (указанном в параметрах инспектора) от каких-либо слоев. Чаще всего это требуется для реализации прыжка, так как класс может проверить стоите ли вы на слое, с тегом <тег слоя земли>, и если да, то персонажу дозволяется прыжок (Ну... Или сбрасывается двойной). Класс содержит в себе protected свойство Pos которое используется в классах-наследниках для получения позиции со смещением, и абстрактный метод IsContactedWithLayer который задает способ проверки столкновения с землей. 

- LayerContactCheckerSphere -- Наследник LayerContactChecker, который проверяет столкновение с объектами в виде окружности в определенной точке. Если в радиусе radius от этой точки произошло столкновение (то есть обнаружено 1 или более коллайдеров) с указанный слоем (collisionLayer), то метод вернет True, иначе False.

Таким образом, если добавить игроку скрипт LayerContactCheckerSphere (или написать свой, который будет по заданному правилу проверять столкнновение) то можно будет реализовать прыжок от земли любым юнитам.


# Планируется реализовать

- Инвентарь и система предметов.
- Атрибуты юнитов.
- Диалоги.