<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Result.aspx.vb" Inherits="MedievalEmpires.Result" %>
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
            <div class="panel-heading">Results</div>
            <div class="panel-body">
                <p>Here are the results</p>
            </div>
            <div class="row">

            </div>
            <div class="col-md-12">
                <div class="col-md-12">
                    <div id="panel-army" class="panel panel-default">
                        <!-- Panel header -->
                        <div class="panel-heading">Your Empire</div>
                        <div class="panel-body">
                            <p>You (Atacker)</p>
                        </div>
                        <!-- List army -->
                        <asp:Label ID="lblTableAttacker" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="col-md-12">
                    <div id="panel-army" class="panel panel-default">
                        <!-- Panel header -->
                        <div class="panel-heading">The Enemy</div>
                        <div class="panel-body">
                            <p>Enemy (Defender)</p>
                        </div>
                        <!-- List army -->
                        <asp:Label ID="lblTableDefender" runat="server"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row" style="text-align: center">
            <div class="col-md-12">
                <asp:Button ID="Button1" runat="server" Text="Dashboard" class="btn btn-primary"/>
            </div>
        </div>
</asp:Content>
