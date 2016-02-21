<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Battle.aspx.vb" Inherits="MedievalEmpires.Battle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div id="panel-shop" class="panel panel-default">
            <div class="panel-heading">Battle Simulator</div>
            <div class="panel-body">
                <p>Go to the battle</p>
            </div>
            <div class="col-sm-12">
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
                <div class="col-sm-6">
                    <div id="panel-army" class="panel panel-default">
                        <!-- Panel header -->
                        <div class="panel-heading">You (Atacker)</div>
                        <asp:Label ID="lblTableBattle" runat="server"></asp:Label>
                        <div class="panel-body">
                            <p>Actual army what you have.</p>
                        </div>
                        <!-- List army -->
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                        <div class="panel-body">
                            <p>Actual currency</p>
                        </div>
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
