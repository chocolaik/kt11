Вариант 2. Зоопарк
IAnimal { string Name { get; } void MakeSound(); } — базовый интерфейс.
ITrainable : IAnimal { string Train(); } — расширяющий интерфейс, возвращающий результат обучения трюку.
Реализуйте Lion, реализующий только IAnimal.
Реализуйте Dog и Dolphin, реализующие ITrainable (а значит, и IAnimal).
Соберите всех животных в List<IAnimal>, обойдите в цикле: выведите имя и звук каждого, а для тех, что дополнительно реализуют ITrainable (проверка через is), дополнительно выведите результат Train().

<img width="1035" height="177" alt="image" src="https://github.com/user-attachments/assets/20ebe913-c41e-4a05-a52d-4d70696723e8" />

<img width="1104" height="353" alt="image" src="https://github.com/user-attachments/assets/6a6b7082-7b37-4cc8-8ee6-5ce6703116be" />

