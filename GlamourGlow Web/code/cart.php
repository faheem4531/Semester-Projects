<?php
  session_start();
  if(!isset($_SESSION['loggedin']) || $_SESSION['loggedin']!=true){
    header("location: login.php");
  }

?>

<?php
  require '_dbcon.php';

  if(isset($_POST['update_update_btn'])){
    $update_value = $_POST['update_quantity'];
    $update_id = $_POST['update_quantity_id'];
    $update_quantity_query = mysqli_query($connect, "UPDATE `cart` SET quantity = '$update_value' WHERE name= '$update_id'");
    if($update_quantity_query){
       header('location:cart.php');
    };
 };
 
 if(isset($_GET['remove'])){
    $remove_id = $_GET['remove'];
    mysqli_query($connect, "DELETE FROM `cart` WHERE name='$remove_id'");
    header('location:cart.php');
 };
 
 if(isset($_GET['delete_all'])){
    mysqli_query($connect, "DELETE FROM `cart`");
    header('location:cart.php');
 }
 
?>

<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>shopping cart</title>
    <link href="stylecart1.css" rel="stylesheet">
    <link rel="icon" href="logo.png" type="x-icon">
    <script src="https://kit.fontawesome.com/75a3d09ada.js" crossorigin="anonymous"></script>
    <link href="https://fonts.googleapis.com/css2?family=Abril+Fatface&family=Caprasimo&family=Roboto:wght@300&display=swap" rel="stylesheet">
</head>
<body>
   
<div class="container">

<section class="shopping-cart">

   <h1 class="heading">shopping cart</h1>

   <table>

      <thead>
         <!-- <th>ID</th> -->
         <!-- <th>image</th> -->
         <th>name</th>
         <th>brand</th>
         <th>price</th>
         <th>quantity</th>
         <th>total </th>
         <th>action</th>
      </thead>
      <tbody>

        <?php 

            $select_cart = mysqli_query($connect, "SELECT * FROM `cart`");
            $grand_total = 0;
            if(mysqli_num_rows($select_cart) > 0){
            while($fetch_cart = mysqli_fetch_assoc($select_cart)){
        ?>

            <tr>
               <!-- <td><?php echo $fetch_cart['cart-id']; ?></td> -->
              <!-- <td><img src="<?php echo $fetch_cart['image']; ?>" ></td> -->
              <td><?php echo $fetch_cart['name']; ?></td>
              <td><?php echo $fetch_cart['brand']; ?></td>
              <td>Rs:<?php echo ($fetch_cart['price']); ?>/-</td>
              <td>
                <form action="" method="post">
                    <input type="hidden" name="update_quantity_id"  value="<?php echo $fetch_cart['name']; ?>" >
                    <input type="number" name="update_quantity" min="1"  value="<?php echo $fetch_cart['quantity']; ?>" >
                    <input type="submit" value="update" name="update_update_btn">
                </form>   
              </td>
              <td>Rs:<?php echo $sub_total = ($fetch_cart['price'] * $fetch_cart['quantity']); ?>/-</td>
              <td><a href="cart.php?remove=<?php echo $fetch_cart['name']; ?>" onclick="return confirm('remove item from cart?')" class="delete-btn"> <i class="fas fa-trash"></i> </a></td>
            </tr>
        <?php
              $grand_total = $grand_total + $sub_total;  
               };
            };
        ?>
            <tr class="table-bottom">
               <td><a href="dashboard.php" class="option-btn" style="margin-top: 0;">continue shopping</a></td>
               <td colspan="3">grand total</td>
               <td>Rs:<?php echo $grand_total; ?>/-</td>
               <td><a href="cart.php?delete_all" onclick="return confirm('are you sure you want to delete all?');" class="delete-btn"> <i class="fas fa-trash"></i> delete all </a></td>
            </tr>
               
       </tbody>

    </table>

    <!-- <div class="checkout-btn">
      <a href="checkout.php" class="btn <?= ($grand_total > 1)?'':'disabled'; ?>">procced to checkout</a>
   </div> -->

   <!-- <form method="POST" style="display:flex; align-items:center; justify-content:center; height:10vh;">
        <button style="font-size:20px;" type="submit" name="logoutsub">Log out</button>
     </form>
     <?php
       if(isset($_POST['logoutsub'])){
         session_unset();
         session_destroy();
         
         header("location: login.php");
         exit;
       }
     ?>

<form method="POST" style="display:flex; align-items:center; justify-content:center;  ">
        <button style="font-size:18px;" type="submit" name="destroysub">Delete account permanently</button>
     </form>
     <?php
       if(isset($_POST['destroysub'])){
        require '_dbcon.php';
        $getusername=$_SESSION['sendusername'];
        $sql="delete from user_details where user_name = '$getusername'";
        $sqlres=mysqli_query($connect, $sql);

        session_unset();
        session_destroy();
        
        header("location: login.php");
        exit;
       }
     ?> -->


</section>

</div>
   
</body>
</html>