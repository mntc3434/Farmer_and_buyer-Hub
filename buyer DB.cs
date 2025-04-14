@model Farmer_MP.ViewModel.BuyerDashboardViewModel
......
<div class="dashboard">
    <!-- Sidebar with navigation -->
    <nav class="sidebar">
        <!-- Profile section at the top -->
        <div class="profile">
            <img src="@Model.ProfilePictureUrl" alt="Profile Picture" class="profile-picture" />
            <h2 class="profile-name">@Model.BuyerName</h2>
        </div>
        <ul class="nav-links">
            <li><a href="@Url.Action("Profile", "Buyer", new { buyerId = Model.BuyerID })" class="nav-link">Profile</a></li>
            <li><a href="@Url.Action("ShoppingCart", "Buyer", new { buyerId = Model.BuyerID })" class="nav-link">Shopping Cart</a></li>
            <li><a href="@Url.Action("OrderHistory", "Buyer", new { buyerId = Model.BuyerID })" class="nav-link">Order History</a></li>
            <li><a href="@Url.Action("Messages", "Buyer", new { buyerId = Model.BuyerID })" class="nav-link">Messages</a></li>
            <!-- Logout button -->
            <li><a href="@Url.Action("Logout", "Buyer")" class="nav-link logout">Logout</a></li>
        </ul>
    </nav>

    <!-- Main content -->
    <main>
        <header>
            <h1>Welcome, @Model.BuyerName</h1>
            <p class="user-details">Email: @Model.Email | Phone: @Model.Phone</p>
        </header>

        <!-- Purchased Products -->
        <section class="dashboard-section">
            <h3>Your Purchased Products</h3>
            <ul class="product-list">
                @foreach (var product in Model.PurchasedProducts)
                {
                    <li class="product-item">@product.Name</li>
                }
            </ul>
        </section>

        <!-- Orders -->
        <section class="dashboard-section">
            <h3>Your Orders</h3>
            <ul class="order-list">
                @foreach (var order in Model.Orders)
                {
                    <li class="order-item">
                        <span class="order-id">Order ID: @order.OrderID</span>
                        <span class="order-status">Status: @order.OrderStatus</span>
                        <span class="order-price">Total Price: @order.TotalPrice</span>
                    </li>
                }
            </ul>
        </section>
    </main>
</div>

<!-- CSS Styling -->
<style>
    body {
        font-family: 'Arial', sans-serif;
        background-color: #f7f9fc;
        color: #333;
        margin: 0;
        padding: 0;
    }

    .dashboard {
        display: flex;
        min-height: 100vh;
        padding: 20px;
        gap: 20px;
    }

    /* Sidebar styling */
    .sidebar {
        width: 220px;
        background-color: #ffffff;
        border-radius: 8px;
        padding: 20px;
        box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
        position: fixed; /* Stick to the left side */
        top: 0;
        left: 0;
        height: 100vh;
    }

    .profile {
        text-align: center;
        margin-bottom: 30px;
    }

    .profile-picture {
        width: 80px;
        height: 80px;
        border-radius: 50%;
        margin-bottom: 10px;
    }

    .profile-name {
        font-size: 18px;
        font-weight: 600;
        color: #264065;
    }

    .nav-links {
        list-style-type: none;
        padding: 0;
    }

    .nav-link {
        display: block;
        padding: 10px;
        margin-bottom: 15px;
        color: #264065;
        text-decoration: none;
        font-size: 16px;
        border-radius: 6px;
        transition: background-color 0.3s;
    }

        .nav-link:hover {
            background-color: #f1f1f1;
        }

    .logout {
        background-color: #f44336;
        color: #fff;
        text-align: center;
        padding: 12px;
        border-radius: 6px;
        font-weight: bold;
    }

        .logout:hover {
            background-color: #d32f2f;
        }

    /* Main content styling */
    main {
        flex-grow: 1;
        margin-left: 240px; /* Leave space for the fixed sidebar */
        background-color: #ffffff;
        border-radius: 8px;
        padding: 20px;
        box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
        overflow-y: auto;
    }

    header {
        margin-bottom: 20px;
    }

    h1 {
        font-size: 28px;
        font-weight: 600;
        color: #264065;
    }

    .user-details {
        font-size: 16px;
        color: #5c6a75;
    }

    .dashboard-section {
        margin-bottom: 30px;
    }

        .dashboard-section h3 {
            font-size: 22px;
            color: #264065;
            margin-bottom: 10px;
        }

    .product-list, .order-list {
        list-style-type: none;
        padding: 0;
    }

    .product-item, .order-item {
        background-color: #fafafa;
        border-radius: 8px;
        padding: 12px;
        margin-bottom: 10px;
        box-shadow: 0 2px 5px rgba(0, 0, 0, 0.05);
        font-size: 16px;
        color: #555;
    }

    .product-item {
        font-weight: 500;
    }

    .order-item {
        display: flex;
        justify-content: space-between;
        align-items: center;
    }

    .order-id, .order-status, .order-price {
        font-size: 14px;
        color: #777;
    }

    .order-id {
        font-weight: 500;
    }

    .order-status {
        color: #3cb371; /* Green for 'Completed' orders */
    }

    .order-price {
        font-weight: 600;
        color: #264065;
    }
</style>
