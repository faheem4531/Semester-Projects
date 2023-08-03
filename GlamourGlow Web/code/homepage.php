<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>homepage</title>
    <link href="stylehomepage.css" rel="stylesheet">
    <link rel="icon" href="logo.png" type="x-icon">
    <!-- <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@300&display=swap" rel="stylesheet"> -->
    <!-- <link href="https://fonts.googleapis.com/css2?family=Abril+Fatface&family=Caprasimo&family=Roboto:wght@300&display=swap" rel="stylesheet"> -->
    <link href="https://fonts.googleapis.com/css2?family=Abril+Fatface&family=Caprasimo&family=Roboto:wght@300&display=swap" rel="stylesheet">
   
</head>
<body>
    <div class="heading">
        <h1>GLAMOASIS</h1>
        <i><h4>Unlock Your Inner Glow</h4></i>
    </div>
    <!----------signup----------->
    <div class="Signup">
        <a href="signup.php" class="Signup_btn">signup</a>
    </div>
    <!----------login----------->
    <div class="login">
        <a href="login.php" class="login_btn">Login</a>
    </div>

    <?php
     if(isset($_POST['sub'])){
        require '_dbcon.php';
     }
    ?>
</body>
</html>