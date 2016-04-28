<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Battle.aspx.vb" Inherits="MedievalEmpires.Battle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        input[type="number"] {
            display: inline;
            width: 50px;
            text-align: center;
            padding: 0;
        }

        .btn {
            display: inline-block;
        }
        button, html input[type="button"], input[type="reset"], input[type="submit"] {
            height: auto;
        }

    </style>
    <div class="row">
        <div id="panel-shop" class="panel panel-default">
            <div class="panel-heading">Battle Simulator</div>
            <div class="panel-body">
                <p>Go to the battle</p>
            </div>
            <div class="row">

            </div>
            <div class="col-md-12">
                <div class="col-md-6">
                    <div id="panel-army" class="panel panel-default">
                        <!-- Panel header -->
                        <div class="panel-heading">Your Empire</div>
                        <div class="panel-body">
                            <p>You (Atacker)</p>
                            <p>You army ready to fight</p>
                        </div>
                        <!-- List army -->
                        <asp:Label ID="lblArmyToFight" runat="server"></asp:Label>
                        <div class="panel-body">
                            <p>Actual currency</p>
                        </div>
                        <asp:Label ID="lblCurrency" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="col-md-6">
                    <div id="panel-army" class="panel panel-default">
                        <!-- Panel header -->
                        <div class="panel-heading">
                            <p>The Enemy (Defender)</p>
                        </div>
                        <asp:Label ID="lblArmyEnemy" runat="server"></asp:Label>
                        <div class="panel-body">
                            <p>Army from your enemy.</p>
                        </div>
                        <!-- List army -->
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row" style="text-align: center">
            <div class="col-md-12">
                <asp:Button ID="Button1" runat="server" Text="Battle Now" class="btn btn-primary"/>
            </div>
        </div>
</asp:Content>
