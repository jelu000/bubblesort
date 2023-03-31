import random
import sortmodule

#Visar hur en Bubblesort går till

#List is a collection which is ordered and changeable. Allows duplicate members.
#Tuple is a collection which is ordered and unchangeable. Allows duplicate members.
#Set is a collection which is unordered, unchangeable*, and unindexed. No duplicate members.
#Dictionary is a collection which is ordered** and changeable. No duplicate members.

looping = True
listnumbers = []

for tnum in range(5):
    tslumptal = random.randint(0, 100)
    #print(tslumptal)
    listnumbers.append(tslumptal)



while looping:

    val = sortmodule.create_menu()

    if (val == "1"):
        print("\n-Skriver listnumbers med slumpade tal----------------------------------")
        sortmodule.print_list_numbers(listnumbers)
        print("\n-Sorterar med en gammal BubbelSort--------------------------")
        nysorterad_listnumbers = sortmodule.bubble_sort(listnumbers)
        #sortmodule.print_set(nysorterad_listnumbers)
        sortmodule.print_list_numbers(nysorterad_listnumbers)
        
        fortsatt = input("\nVill du fortsätta? j/n \n")
        if (fortsatt == "n"):
            break
    
    elif (val == "2"):
        print("\n-Skriver listnumbers med slumpade tal----------------------------------")
        listnumbers2sort = list(listnumbers)
        sortmodule.print_list_numbers(listnumbers)
        print("\n-Sorterar med Python sort()--------------------------")
        listnumbers2sort.sort()
        sortmodule.print_list_numbers(listnumbers2sort)
        
        fortsatt = input("\nVill du fortsätta? j/n \n")
        if (fortsatt == "n"):
            break

    else:
        break


