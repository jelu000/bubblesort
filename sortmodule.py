#Visar hur en BubbleSort går till
def bubble_sort(tset):
    
    tlist = tset.copy()

    langd = len(tlist)



    bytplats = False

    for i in range(langd-1):
        
        for j in range(0, langd-i-1):

            if tlist[j] > tlist[j + 1]:
                bytplats = True
                tlist[j], tlist[j + 1] = tlist[j + 1], tlist[j]

        if not bytplats:
            return

    return tlist

def print_list_numbers(tlist):

    string_numbers = " ".join(str(num) for num in tlist)
    print(string_numbers)

def create_menu():
    print("\n---:MENY SORTERINGS TEST-----\n")
    print("1. Använd min egengjorda Bubblesort")
    print("2. Använd Pythons sort() funtion")
    print("3. Avsluta programmet\n")

    val = input("\nMata in val: ")
    
    return val


