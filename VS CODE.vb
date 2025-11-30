<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Python Code Display</title>
    <link rel="stylesheet" href="{{ url_for('static', filename='style.css') }}">
    <style>
        /* CSS for the code display box */
        .code-display {
            background-color: #272822; /* Dark background for code */
            color: #f8f8f2; /* Light text */
            padding: 15px;
            border-radius: 8px;
            overflow-x: auto; /* Allows scrolling if code is too wide */
            margin-top: 15px;
            margin-bottom: 25px;
            font-family: 'Consolas', 'Monaco', monospace; /* Monospaced font for code */
            white-space: pre-wrap; /* Keeps indentation and line breaks */
            border: 1px solid #555;
        }
    </style>
</head>
<body>
    <div class="container">
        <header>
            <h1>My Integrated Python Scripts 💻</h1>
            <p>The code below is shown exactly as provided, with functional forms above/below.</p>
        </header>

        <main>
            <section class="tool-section" id="calculator-section">
                <h2>🔐 Functional Calculator</h2>
                
                {% if not password_correct %}
                <form method="POST" action="/check_password">
                    <p class="hint">HINT = SUM OF FIRST 5 NUMBERS (1+2+3+4+5)</p>
                    <input type="password" name="password_attempt" placeholder="ENTER THE PASSWORD" required>
                    <button type="submit">Submit Password</button>
                </form>
                {% else %}
                <p class="welcome">WELCOME! CALCULATOR</p>
                <form method="POST" action="/calculate">
                    <input type="number" name="num1" placeholder="First Number" step="any" required>
                    <input type="text" name="operation" placeholder="Operation (+, -, *, /, //, %, **)" required>
                    <input type="number" name="num2" placeholder="Second Number" step="any" required>
                    <button type="submit">Calculate</button>
                </form>
                {% endif %}

                <div class="result-box" id="calc-result">
                    {{ calc_result if calc_result is not none else 'Awaiting password or input...' }}
                </div>
                
                <h3>Original Calculator Python Code:</h3>
                <pre class="code-display">
print("ENTER THE PASSWORD")
print("HINT = SUM OF FIRST 5 NUMBERS")    # 1+2+3+4+5 = 15

p = int(input("ENTER THE PASSWORD: "))

if p == 15:
    print("WELCOME")
    print("CALCULATOR")

    a = int(input("ENTER A NUMBER: "))
    b = int(input("ENTER THE NEXT NUMBER: "))
    op = input("ENTER THE OPERATION (+, -, *, /, //, %, **): ")

    if op == "+":
        print("THE ADDITION IS", a + b)
    elif op == "-":
        print("THE SUBTRACTION IS", a - b)
    elif op == "*":
        print("THE MULTIPLICATION IS", a * b)
    elif op == "/":
        print("THE DIVISION IS", a / b)
    elif op == "//":
        print("THE FLOOR DIVISION IS", a // b)
    elif op == "%":
        print("THE MODULUS IS", a % b)
    elif op == "**":
        print("THE EXPONENT IS", a ** b)
    else:
        print("CANNOT BE DETERMINED")

    print("THANK YOU FOR YOUR TIME")

else:
    print("WRONG PASSWORD....TRY AGAIN LATER")
                </pre>
            </section>

            <hr>

            <section class="tool-section" id="shapes-section">
                <h2>📐 Functional Area & Perimeter of Shapes</h2>
                
                <form method="POST" action="/shape_calc">
                    <input type="text" name="shape_name" placeholder="Shape (e.g., circle, rectangle, triangle)" required>
                    <input type="number" name="dim1" placeholder="Dimension 1 (Side/Length/Radius)" step="any" required>
                    <input type="number" name="dim2" placeholder="Dimension 2 (Breadth/Side 2) (Optional)" step="any">
                    <input type="number" name="dim3" placeholder="Dimension 3 (Side 3) (Optional)" step="any">
                    <input type="number" name="height" placeholder="Height (For Area/Parallelogram) (Optional)" step="any">
                    <button type="submit">Calculate Shape</button>
                </form>

                <div class="result-box" id="shape-result">
                    {{ shape_result if shape_result is not none else 'Awaiting input...' }}
                </div>

                <h3>Original Shape Calculator Python Code:</h3>
                <pre class="code-display">
s = input("ENTER THE SHAPE: ")

if s == "rectangle":
    print("YOU GOT A RECTANGLE")
    l = int(input("ENTER THE LENGTH: "))
    b = int(input("ENTER THE BREADTH: "))
    p = 2 * (l + b)
    a = l * b
    print("THE PERIMETER IS", p)
    print("THE AREA IS", a)
    print("THANK YOU FOR YOUR TIME")

elif s == "square":
    print("YOU GOT A SQUARE")
    s1 = int(input("ENTER THE SIDE: "))
    peri = s1 * 4
    ar = s1 * s1
    print("THE PERIMETER IS", peri)
    print("THE AREA IS", ar)
    print("THANK YOU FOR YOUR TIME")

elif s == "circle":
    print("YOU GOT A CIRCLE")
    pi = 3.14159265359
    r = int(input("ENTER THE RADIUS: "))
    perim = 2 * pi * r
    are = pi * r * r
    print("THE PERIMETER IS", perim)
    print("THE AREA IS", are)
    print("THANK YOU FOR YOUR TIME")

elif s == "triangle":
    print("YOU GOT A TRIANGLE")
    s1 = int(input("ENTER THE 1ST SIDE: "))
    s2 = int(input("ENTER THE 2ND SIDE: "))
    s3 = int(input("ENTER THE THIRD SIDE: "))
    base = int(input("ENTER THE BASE: "))
    height = int(input("ENTER THE HEIGHT: "))
    perime = s1 + s2 + s3
    area = 0.5 * base * height
    print("THE PERIMETER IS", perime)
    print("THE AREA IS", area)
    print("THANK YOU FOR YOUR TIME")

elif s == "parallelogram":
    print("YOU GOT A PARALLELOGRAM")
    l1 = int(input("ENTER THE LENGTH: "))
    b2 = int(input("ENTER THE BREADTH: "))
    p1 = 2 * (l1 + b2)
    a1 = l1 * b2
    print("THE PERIMETER IS", p1)
    print("THE AREA IS", a1)
    print("THANK YOU FOR YOUR TIME")

else:
    print("INVALID SHAPE ENTERED")
                </pre>
            </section>
        </main>
    </div>
</body>
</html>