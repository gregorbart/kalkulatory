
num1 = int(input("Wprowadź pierwszą liczbę: "))
num2 = int(input("Wprowadź drugą liczbę: "))

print("Działania:")
print("      +: Dodaj")
print("      -: Odejmnij")
print("      *: Pomnórz")
print("      /: Podziel")

dzi = input("Wprowadź działanie: ")

result=0

def printtheresult(n1,n2,div,res):
    print(f"{n1}{div}{n2}={res}")

if dzi == "+":
    result=num1+num2
    printtheresult(num1,num2,dzi,result)
elif dzi == "-":
    result=num1-num2
    printtheresult(num1,num2,dzi,result)
elif dzi == "*":
    result=num1*num2
    printtheresult(num1,num2,dzi,result)
elif dzi == "/":
    result=num1/num2
    printtheresult(num1,num2,dzi,result)
else:
    print("Nieprawidłowe działanie")

input("Kliknij enter aby wyłączyć aplikacje...")
