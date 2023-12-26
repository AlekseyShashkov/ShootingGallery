# ShootingGallery
## 🎮Control:
- Управление орудием `WASD`
- Стрельба `F`

## 🎲Game process:
![ShootingGallery2](https://github.com/AlekseyShashkov/ShootingGalleryTMS/assets/17510024/d1c7fa64-3e55-4121-beb7-beabc13c1595)

## 📊UML class diagram:
![ShootingGallery2UML](https://github.com/AlekseyShashkov/ShootingGalleryTMS/assets/17510024/085bcdeb-550a-443e-9e36-0a4c1ce452a3)
Для справки: [UML-диаграммы классов](https://prog-cpp.ru/uml-classes/)

## 📋Scene structure:
![SceneStructure](https://github.com/AlekseyShashkov/ShootingGalleryTMS/assets/17510024/27257380-03c4-4461-916e-9878d7c90777)

## 📂Folder structure:
```
+-- Assets
|   +-- _Scripts
|       +-- Cannon
|       +-- Input
|       +-- Interface
|       +-- Projectile
|       +-- Target
|       +-- UI
|   +-- Art
|       +-- Cannons
|       +-- Materials
|       +-- Plane
|       +-- Targets
|       +-- UI
|   +-- Plugins
|   +-- Prefabs
|   +-- Resources
|   +-- Scenes
|   +-- TextMesh Pro
```

## 🔧Program logic:
|Purpose|File|
|:---------|:---------|
|Обработка команд игрока|![PlayerInput.cs](https://github.com/AlekseyShashkov/ShootingGalleryTMS/blob/main/Assets/_Scripts/Input/PlayerInput.cs)|
|Управление орудием|![MortarModifier.cs](https://github.com/AlekseyShashkov/ShootingGalleryTMS/blob/main/Assets/_Scripts/Cannon/MortarModifier.cs)|
|Оружейный снаряд|![Cannonball.cs](https://github.com/AlekseyShashkov/ShootingGalleryTMS/blob/main/Assets/_Scripts/Projectile/Cannonball.cs)|
|Магазин снарядов (object pool)|![ProjectileStore.cs](https://github.com/AlekseyShashkov/ShootingGalleryTMS/blob/main/Assets/_Scripts/Projectile/ProjectileStore.cs)|
|Мишень|![Cube.cs](https://github.com/AlekseyShashkov/ShootingGalleryTMS/blob/main/Assets/_Scripts/Target/Cube.cs)|
|Менеджер мишеней|![TargetManager.cs](https://github.com/AlekseyShashkov/ShootingGalleryTMS/blob/main/Assets/_Scripts/Target/TargetManager.cs)|

## 📚Literature:
- [Instantiating Prefabs at run time](https://docs.unity3d.com/Manual/InstantiatingPrefabs.html)
- [Функции событий столкновений](https://ru.stackoverflow.com/questions/1274786/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D0%B8-%D1%81%D0%BE%D0%B1%D1%8B%D1%82%D0%B8%D0%B9-%D1%81%D1%82%D0%BE%D0%BB%D0%BA%D0%BD%D0%BE%D0%B2%D0%B5%D0%BD%D0%B8%D0%B9-oncollisionenter-oncollisionenter2d-oncollisions)
- [Object Pool](https://riptutorial.com/unity3d/example/7471/object-pool)
- [Unity отсчет времени](https://ru.stackoverflow.com/questions/765856/unity-%D0%BE%D1%82%D1%81%D1%87%D0%B5%D1%82-%D0%B2%D1%80%D0%B5%D0%BC%D0%B5%D0%BD%D0%B8)
- [Unity Architecture for Noobs](https://www.youtube.com/watch?v=tE1qH8OxO2Y)
- [HEALTHBAR in Unity](https://www.youtube.com/watch?v=6U_OZkFtyxY)
