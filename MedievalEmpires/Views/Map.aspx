<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Map.aspx.vb" Inherits="MedievalEmpires.Map" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
	#map{
		vertical-align: middle;
		width: 498px;
		display: block;
		margin: 0 auto;

	}
	.fila{
		display:block;
		height:160px;
	}
	.column{
		display: inline-block;
		width:163px;
		height:160px;
		line-height: 163px;
		text-align: center;
	}
	.fila-side{
		border-top: 1px solid black;
		border-bottom: 1px solid black;
	}
	.col-side{
		border-left: 1px solid black;
		border-right: 1px solid black;
	}
	.tooltip {
		text-decoration:none;
		position:relative;
		opacity: 1;
	}
	.tooltip span {
		line-height: 1;
		text-align: left;
		padding: 0 2em 2em 2em;
		border-radius: 5px;
		display:none;
	}
	.tooltip:hover span {
		display:block;
		position:fixed;
		overflow:hidden;
		background-color: #eee;
	}
	.tooltip:hover span p{
		margin:0;
		padding:0;
	}
    .modal{
        /*top: 30%;*/  
    }
	.modal-body-left{
		float: left;
	}
	.modal-body-right{
		float: right;
	}
    .modal-footer {
        border: none
    }


</style>
    <div id="map">
	    <h2>BATTLE MAP</h2>
	    <div id="fila1" class="fila fila-side">
		    <div id="col1" class="column col-side tooltip">
			    <span>
			        <h3>Roman Town 1</h3>
				    <p>Player: Krotus</p>
				    <p>Population: 100</p>
				    <p>Empire: Roman</p>
	    	    </span>
	        </div>
		    <div id="col2" class="column tooltip">
			    <span>
			        <h3>Roman Town 2</h3>
				    <p>Player: Krotus</p>
				    <p>Population: 100</p>
				    <p>Empire: Roman</p>
	    	    </span>
	        </div>
		    <div id="col3" class="column col-side tooltip">
			    <span>
			        <h3>Roman Town 3</h3>
				    <p>Player: Krotus</p>
				    <p>Population: 100</p>
				    <p>Empire: Roman</p>
	    	    </span>
	        </div>
	    </div>
	    <div id="fila2" class="fila">
		    <div id="col4" class="column col-side tooltip">
			    <span>
			        <h3>Roman Town 4</h3>
				    <p>Player: Krotus</p>
				    <p>Population: 100</p>
				    <p>Empire: Roman</p>
	    	    </span>
	        </div>
		    <div id="col5" class="column tooltip">
			    <span>
			        <h3>Roman Town 5</h3>
				    <p>Player: Krotus</p>
				    <p>Population: 100</p>
				    <p>Empire: Roman</p>
	    	    </span>
	        </div>
		    <div id="col6" class="column col-side tooltip">
			    <span>
			        <h3>Roman Town 6</h3>
				    <p>Player: Krotus</p>
				    <p>Population: 100</p>
				    <p>Empire: Roman</p>
	    	    </span>
	        </div>
	    </div>
	    <div id="fila3" class="fila fila-side">
		    <div id="col7" class="column col-side tooltip">
			    <span>
			        <h3>Roman Town 7</h3>
				    <p>Player: Krotus</p>
				    <p>Population: 100</p>
				    <p>Empire: Roman</p>
	    	    </span>
	        </div>
		    <div id="col8" class="column tooltip">
			    <span>
			        <h3>Roman Town 8</h3>
				    <p>Player: Krotus</p>
				    <p>Population: 100</p>
				    <p>Empire: Roman</p>
	    	    </span>
	        </div>
		    <div id="col9" class="column col-side tooltip">
			    <span>
			        <h3>Roman Town 9</h3>
				    <p>Player: Krotus</p>
				    <p>Population: 100</p>
				    <p>Empire: Roman</p>
	    	    </span>
	        </div>
	    </div>
    </div>

    <!-- Modal -->
	<div style="z-index:9999" class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
	  <div class="modal-dialog" role="document">
	    <div class="modal-content">
	      <div class="modal-header">
	        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
	        <h4 class="modal-title" id="myModalLabel">Modal title</h4>
	      </div>
	      <div class="modal-body">
	        <div class="modal-body-left">
    	  		<p id="modal-player">One fine body…</p>
    	  		<p id="modal-population">One fine body…</p>
    	  		<p id="modal-empire">One fine body…</p>
    	  	</div>
    	    <div class="modal-body-right">
    	    	<p>ATTACK</p>
    	    	<p>DEFENSE</p>
    			<p>SCOUT</p>
    	    </div>
	      </div>
	      <div class="modal-footer">
	        
	      </div>
	    </div>
	  </div>
	</div>

    <script>
		//TODO
		var tooltips = document.querySelectorAll('.tooltip span');
		var empires = document.getElementsByClassName('column');
		for(var  i = 0 ; i < empires.length ; i++){
			empires[i].onclick = function(){
				//alert("empire " + this.id);
				var title = $("#" + this.id + " span h3")[0].innerText;
				var player = $("#" + this.id + " span p")[0].innerText;
				var population = $("#" + this.id + " span p")[1].innerText;
				var empire = $("#" + this.id + " span p")[2].innerText;
				$('#myModalLabel').html(title);
				$('#modal-player').html(player);
				$('#modal-population').html(population);
				$('#modal-empire').html(empire);
				$('#myModal').modal('show');
			}
		}

		window.onmousemove = function (e) {
		    var x = (e.clientX + 20) + 'px',
		        y = (e.clientY - 10) + 'px';
		    for (var i = 0; i < tooltips.length; i++) {
		        tooltips[i].style.top = y;
		        tooltips[i].style.left = x;
		    }
		};
	</script>
</asp:Content>
