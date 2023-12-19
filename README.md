# ShootingGallery
## 🎮Control:
- Управление орудием `WASD`
- Стрельба `F`
## 🎲Game process:
![ShootingGallery](https://github.com/AlekseyShashkov/ShootingGalleryTMS/assets/17510024/a6dd29bd-425a-4fa5-8788-f3bab341203c)
## 📊UML class diagram:
![ShootingGalleryUML](https://github.com/AlekseyShashkov/ShootingGalleryTMS/assets/17510024/050b4e05-a0f6-4e3a-a888-584b8856f6d8)
Для справки: [UML-диаграммы классов](https://prog-cpp.ru/uml-classes/)
## 🔧Program logic:
- Обработка команд игрока - ![PlayerInput.cs](https://github.com/AlekseyShashkov/ShootingGalleryTMS/blob/main/Assets/Scripts/Player/PlayerInput.cs)
- Управлени орудием - ![MortarModifier.cs](https://github.com/AlekseyShashkov/ShootingGalleryTMS/blob/main/Assets/Scripts/Cannon/MortarModifier.cs)
- Оружейный снаряд - ![Cannonball.cs](https://github.com/AlekseyShashkov/ShootingGalleryTMS/blob/main/Assets/Scripts/Projectile/Cannonball.cs)
- Магазин снарядов (object pool) - ![ProjectileStore.cs](https://github.com/AlekseyShashkov/ShootingGalleryTMS/blob/main/Assets/Scripts/Projectile/ProjectileStore.cs)
- Мишень - ![Cube.cs](https://github.com/AlekseyShashkov/ShootingGalleryTMS/blob/main/Assets/Scripts/Target/Cube.cs)
## 📚Literature:
- [Instantiating Prefabs at run time](https://docs.unity3d.com/Manual/InstantiatingPrefabs.html)
- [Функции событий столкновений](https://ru.stackoverflow.com/questions/1274786/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D0%B8-%D1%81%D0%BE%D0%B1%D1%8B%D1%82%D0%B8%D0%B9-%D1%81%D1%82%D0%BE%D0%BB%D0%BA%D0%BD%D0%BE%D0%B2%D0%B5%D0%BD%D0%B8%D0%B9-oncollisionenter-oncollisionenter2d-oncollisions)
- [Object Pool](https://riptutorial.com/unity3d/example/7471/object-pool)
- [Unity отсчет времени](https://ru.stackoverflow.com/questions/765856/unity-%D0%BE%D1%82%D1%81%D1%87%D0%B5%D1%82-%D0%B2%D1%80%D0%B5%D0%BC%D0%B5%D0%BD%D0%B8)
