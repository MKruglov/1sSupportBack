import pandas as pd
import os


pd.options.display.max_columns = 20


def encode(string: str):
    """
    Encoded link string for most "security"
    chr - from ASCII code on char
    ord - from char on ASCII code

    :param string:
    :return:
    """
    list_encode = []

    for char in string:
        list_encode.append(ord(char))

    a = []
    for i in range(len(list_encode)):
        if chr(list_encode[i]).isalpha():
            a.append(chr(list_encode[i]+3))
        elif chr(list_encode[i]).isdigit():
            a.append(chr(list_encode[i] + 17))
        else:
            a.append(chr(list_encode[i] + 3))
    return ''.join(a)


def decode(string: str):
    """
    Decoded encoded link
    chr - from ASCII code on char
    ord - from char on ASCII code

    :param string:
    :return:
    """
    list_encode = []

    for char in string:
        if char.islower():
            list_encode.append(chr(ord(char)-3))
        elif char.isupper():
            list_encode.append(chr(ord(char)-17))
        else:
            list_encode.append(chr(ord(char)-3))

    return ''.join(list_encode)


def gen_links(xls_file: str):
    file = os.path.join(os.getcwd(), xls_file)
    xls = pd.ExcelFile(file)
    df = xls.parse(xls.sheet_names[0])
    INN = df.keys()[0]
    login = df.keys()[1]
    INN_raw_list = [x for x in df[INN]]
    login_list = [x for x in df[login]]
    INN_list = []
    for x in INN_raw_list:
        try:
            INN_list.append([t for t in x.split() if t.isdigit()])
        except AttributeError as e:
            INN_list.append([None, None])

    link_list = []
    for x in range(58):
        if INN_list[x][0] != None:
            link_list.append(f'inn={INN_list[x][0]}&login={login_list[x]}')
        else:
            link_list.append(f'inn={INN_list[x-1][0]}&login={login_list[x]}')
    return link_list


if __name__ == '__main__':
    list_end = []

    for x in gen_links('dannye_s_its.xlsx'):
        list_end.append(encode(x))

    file = open('link.txt', 'w')

    for x in list_end:
        file.write(f'{x}\n')
