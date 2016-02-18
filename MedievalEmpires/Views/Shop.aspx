<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Shop.aspx.vb" Inherits="MedievalEmpires.Shop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        #panel-army {
            text-align: justify;
            width: 50%;
        }

        tr,
        th {
            text-align: center;
        }

        input[type="number"] {
            display: inline;
            width: 50px;
            text-align: center;
            padding: 0;
        }

        .align-right {
            text-align: right;
            margin: 10px;
        }

        .btn {
            display: inline-block;
        }

        li > span {
            font-weight: bold;
        }
    </style>
    <div class="row">
        <div class="col-sm-6">
            <div id="panel-shop" class="panel panel-default">
                <div class="panel-heading">Shopping</div>
                <div class="panel-body">
                    <p>Here you can buy soldiers to fight with you!</p>
                </div>
                <!--table-->
                <asp:Label ID="lblTableShop" runat="server"></asp:Label>
                <div class="align-right">
                    <asp:Button ID="btnBuy" runat="server" Text="BUY"/>
                </div>
            </div>
        </div>

        <div class="col-sm-6">
            <div id="panel-army" class="panel panel-default">
                <!-- Panel header -->
                <div class="panel-heading">Your Empire</div>
                <div class="panel-body">
                    <p>Actual army what you have.</p>
                </div>
                <!-- List army -->
                <asp:Label ID="lblListArmy" runat="server"></asp:Label>
                <div class="panel-body">
                    <p>Actual currency</p>
                </div>
                <asp:Label ID="lblCurrency" runat="server"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
