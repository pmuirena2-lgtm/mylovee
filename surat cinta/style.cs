/* BODY & HEADER */
body {
    margin: 0;
    font-family: 'Segoe UI', sans-serif;
    background: linear-gradient(135deg, #ffe4e1, #fff);
    text-align: center;
}

header {
    background: #ff9aa2;
    padding: 20px;
    color: white;
}

header h1 {
    margin: 0;
    font-size: 28px;
}

header p {
    margin: 5px 0 0;
    font-size: 16px;
}

/* GALLERY */
.gallery {
    display: flex;
    justify-content: center;
    flex-wrap: wrap;
    gap: 20px;
    padding: 20px;
}

.card {
    background: white;
    border-radius: 15px;
    box-shadow: 0 5px 15px rgba(0,0,0,0.1);
    overflow: hidden;
    width: 220px;
    text-align: center;
    transition: transform 0.3s;
}

.card img {
    width: 100%;
    display: block;
}

.card p {
    margin: 10px 0;
    font-size: 14px;
    color: #333;
}

.card:hover {
    transform: scale(1.05);
}

/* NEXT BUTTON */
.next-btn {
    margin: 20px 0;
}

.next-btn button {
    padding: 12px 25px;
    border: none;
    border-radius: 20px;
    background: #ff5e78;
    color: white;
    font-size: 16px;
    cursor: pointer;
    transition: 0.3s;
}

.next-btn button:hover {
    background: #ff2e63;
}

/* LOGIN PAGE */
body.login {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
}

.login-box {
    background: rgba(255,255,255,0.95);
    padding: 35px;
    border-radius: 20px;
    box-shadow: 0 10px 25px rgba(0,0,0,0.2);
    width: 300px;
    text-align: center;
}

.login-box input {
    width: 90%;
    padding: 12px;
    margin: 10px 0;
    border-radius: 10px;
    border: 1px solid #ccc;
}

.login-box button {
    padding: 12px 25px;
    border: none;
    border-radius: 20px;
    background: #ff5e78;
    color: white;
    font-size: 15px;
    cursor: pointer;
    transition: 0.3s;
}

.login-box button:hover {
    background: #ff2e63;
}

/* RESPONSIVE */
@media (max-width: 600px) {
    .gallery {
        flex-direction: column;
        align-items: center;
    }
    .card {
        width: 90%;
    }
}
