dep = 0
count = [0,0,0,0,0,0]
quit = 999


def getReady():
    dep = int(input(print("Enter a dependency or '999' to quit: ")))
    return dep

def countDependents(dep):
    count[dep] = count[dep] + 1
    dep = int(input(print("Enter Employee Dependency: ")))
    return dep

def finishup():
    print("Dependents Count \n")
    dep = 0
    while dep < 6:
        print("{0}, {1}".format(dep, count[dep]))
        dep += 1
    exit()


while dep != quit:
    countDependents(dep)
    if dep == quit:
        finishup()