def media(*parametri):
    somma = 0

    for val in parametri:
        somma += val
    
    return somma / len(parametri)

print("Media 1 = ", media(1,2,3))
print("Media 2 = ", media(1,2,3,4,5,6))
print("Media 3 = ", media())                     #O problema esta na divisao por zero, pois a funçao len serve para contar o numero de parametros adicionados neste caso.

#Como neste caso existe um looping é possivel usar um contador para chegar no mesmo lugar,
#mas se nao existir um looping e for simplesmente uma formula talvez se torne impossivel chegar ao mesmo lugar.