 #Задание: 
 # 1 Создать словарь из 10 студентов, поставить оценки (возможные оценки: 5, 4, 3) 
# 2 сколько парней 
# 3 посчитать средний бал успеваемости студента, и всей группы. 
# Задачи: 
# 1 создать функцию для ввода с клавиатуры (с входными параметрами : текст и тип вводимых данных. 
# 2 создать функцию для добавления словаря. 
# 3 создать картеж со списком: фамилия, имя, отчество, возраст, пол, номер группы, оценки. (ключи на латинице)
# 4 создать массив журнал (16 дат занятий)

def text_input():
    text = input()
    return text


def slovar():
    slov = {'student1': {'surname': '', 'name': '', 'patronymic': '', 'age': '', 'gender': '', 'number groups': '', 'estimation': ''},
            'student2': {'surname': '', 'name': '', 'patronymic': '', 'age': '', 'gender': '', 'number groups': '', 'estimation': ''},
            'student3': {'surname': '', 'name': '', 'patronymic': '', 'age': '', 'gender': '', 'number groups': '', 'estimation': ''},
            'student4': {'surname': '', 'name': '', 'patronymic': '', 'age': '', 'gender': '', 'number groups': '', 'estimation': ''},
            'student5': {'surname': '', 'name': '', 'patronymic': '', 'age': '', 'gender': '', 'number groups': '', 'estimation': ''},
            'student6': {'surname': '', 'name': '', 'patronymic': '', 'age': '', 'gender': '', 'number groups': '', 'estimation': ''},
            'student7': {'surname': '', 'name': '', 'patronymic': '', 'age': '', 'gender': '', 'number groups': '', 'estimation': ''},
            'student8': {'surname': '', 'name': '', 'patronymic': '', 'age': '', 'gender': '', 'number groups': '', 'estimation': ''},
            'student9': {'surname': '', 'name': '', 'patronymic': '', 'age': '', 'gender': '', 'number groups': '', 'estimation': ''},
            'student9': {'surname': '', 'name': '', 'patronymic': '', 'age': '', 'gender': '', 'number groups': '', 'estimation': ''}}

    for i in slov:
        print(i)
        for j in slov[i]:
            print('Введите', j)
            slov[i][j] = text_input()

    for i in slov:
        for j in slov[i]:
            if slov[i][j] >= '3' and slov[i][j] <= '5':
                ...
            else:
                print('возможные оценки: 5, 4, 3')
                slov()

        return slov
            

    print(slov)


if __name__ == '__main__':
    slovar()

