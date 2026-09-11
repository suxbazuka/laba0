# ShapesDrawing — лабораторная работа (WPF + Git)

Готовый проект WPF (.NET 6), реализующий рисование геометрических фигур
на холсте с классами `Point2D`, `Triangle`, `Quadrilateral` (прямоугольник/квадрат).

## Функционал
- Рисование треугольника и прямоугольника/квадрата на холсте `Scene`.
- Размеры/координаты можно задать вручную или сгенерировать случайно.
- Перемещение всех фигур по осям X и Y (поля dX/dY + кнопка).
- Кнопка очистки сцены.

## Структура файлов
- `Point2D.cs` — класс точки (X, Y).
- `IShape.cs` — общий интерфейс фигур (`Draw`, `Move`).
- `Triangle.cs` — класс треугольника (агрегирует 3 точки).
- `Quadrilateral.cs` — класс четырёхугольника (начальная точка + ширина + высота).
- `MainWindow.xaml` / `MainWindow.xaml.cs` — интерфейс и логика приложения.
- `App.xaml` / `App.xaml.cs` — точка входа WPF-приложения.

## Как открыть проект
1. Установите Visual Studio с рабочей нагрузкой ".NET desktop development".
2. Откройте папку `ShapesDrawing` в Visual Studio (Файл → Открыть → Папка,
   либо просто дважды кликните по `ShapesDrawing.csproj`).
3. Нажмите F5, чтобы собрать и запустить проект.

## Как выполнить требования по Git (по заданию лабораторной)

Файлы уже готовы, но для зачёта лабораторной важно повторить сам процесс
работы с Git так, как описано в задании. Рекомендуемая последовательность:

```bash
# 1. Инициализация репозитория и первый коммит
cd ShapesDrawing
git init
git add App.xaml App.xaml.cs MainWindow.xaml MainWindow.xaml.cs ShapesDrawing.csproj .gitignore
git commit -m "Начальная структура WPF-проекта"

# 2. Класс точки
git add Point2D.cs
git commit -m "Добавлен класс Point2D"

# 3. Интерфейс фигур и класс треугольника + отрисовка
git add IShape.cs Triangle.cs
git commit -m "Добавлен класс Triangle и функции отрисовки"

# 4. Ветка для класса четырёхугольника
git checkout -b feature/rectangle
git add Quadrilateral.cs
git commit -m "Добавлен класс Quadrilateral (прямоугольник/квадрат)"
git checkout main
git merge feature/rectangle -m "Слияние feature/rectangle в main"

# 5. Ветка для функционала перемещения фигур
git checkout -b feature/move-shapes
git add MainWindow.xaml MainWindow.xaml.cs
git commit -m "Добавлен функционал перемещения фигур по сцене"

# 6. Отправка ветки на GitHub и создание Pull Request
git remote add origin <URL_вашего_репозитория_на_GitHub>
git push -u origin main
git push -u origin feature/move-shapes
# Далее на github.com откройте репозиторий, нажмите
# "Compare & pull request", заполните описание и нажмите
# "Create pull request", затем "Merge pull request" -> "Confirm merge".

# 7. Обновление main локально после слияния через PR
git checkout main
git pull origin main
```

Эта последовательность покрывает все обязательные пункты задания:
репозиторий, связанный с GitHub, коммиты по каждому значимому этапу,
отдельные ветки (`feature/rectangle`, `feature/move-shapes`) и слияние
как напрямую (merge), так и через Pull Request на GitHub.

## Возможные доработки (по желанию)
- Раздельное перемещение конкретной фигуры (сейчас перемещаются все сразу).
- Выбор цвета фигуры перед добавлением.
- Сохранение/загрузка сцены в файл.
