function generateChart(elem, data) {
	var ctx = document.getElementById(elem);
	var myChart = new Chart(ctx, { type: 'pie', data: { labels: ["Active", "Recovered", "Deaths"], datasets: [{ data: [10, 80, 10] }] }});
}

function generatePieChart(elem, strData) {
	var ctx = document.getElementById(elem);
	var data = JSON.parse(strData);
	var myChart = new Chart(ctx, { type: 'pie', data: data });
}

function generateBarChart(elem, strData) {
	var ctx = document.getElementById(elem);
	var data = JSON.parse(strData);
	var myChart = new Chart(ctx, { type: 'bar', data: data });
}

function generateLineChart(elem, strData) {
	var ctx = document.getElementById(elem);
	var data = JSON.parse(strData);
	var myChart = new Chart(ctx, { type: 'line', data: data });
}

function test(elem, data) {
	var ctx = document.getElementById(elem);
	alert("Invoked for " + elem);
	console.log(data);
}