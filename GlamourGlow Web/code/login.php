<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="icon" href="logo.png" type="x-icon">
    <title>login</title>
    <style>
      body {
      background-image: url('background.jpg');
      background-size: contain;
      background-repeat: no-repeat;  
      }
    </style>
</head>
<body>
      <div style="display:flex; align-items:center; justify-content:center; height:100vh">
       <div>
         <h1 style="font-size:40px;">Login.</h1>
         <form method="POST" style="font-size:20px;">
            

            <label for="">Enter username : </label><br>
            <input style="font-size:20px;" type="text" name="getusername"><br>

            <label for="">Enter password : </label><br>
            <input style="font-size:20px;" type="password" name="getpass"><br><br>

          
            <button style="font-size:20px;" type="submit" name="sub">Log in</button>
         </form>

         <?php
           if(isset($_POST['sub'])){
            require '_dbcon.php';
            
            $getusername=$_POST['getusername'];
            $getpassword=$_POST['getpass'];

            $sql1="select * from user_details where user_name = '$getusername' and password='$getpassword';";
            $sqlres=mysqli_query($connect, $sql1);
            $countrows=mysqli_num_rows($sqlres);

            if($countrows == 0){
                echo "account not available.Please try again OR <a href='signup.php'>SignUp.</a>";
            }else{
                session_start();
                $_SESSION['loggedin']=true;
                $_SESSION['sendusername']=$getusername;
                header("location: dashboard.php");
            }
           }
         ?>
       </div>
      </div>
</body>
</html>