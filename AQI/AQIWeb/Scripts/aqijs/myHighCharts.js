
Highcharts.setOptions({
  global: {
    useUTC: false
  }
});

var chart;
$(document).ready(function () {
  chart = new Highcharts.Chart({
    chart: {
      renderTo: 'container',
      defaultSeriesType: 'spline',
      marginRight: 10,
      width:1200,
      events: {
        load: function () {

          var series = this.series[0];
          setInterval(function () {
            var y = Math.random();
            var x = new Date().getSeconds() * 20;
            series.addPoint([x, y], true, true);
          }, 1000);
        }
      }
    },
    title: {
      text: 'Live random data'
    },
    xAxis: {
     
    },
    yAxis: {
      title: {
        text: 'Value'
      },
      plotLines: [{
        value: 0,
        width: 1,
        color: '#808080'
      }]
    },
    tooltip: {
      formatter: function () {
        return '<b>' + this.series.name + '</b><br/>';
      }
    },
    legend: {
      enabled: false
    },
    exporting: {
      enabled: false
    },
    series: [{
      name: 'Random data',
      data: (function () {
        var data = [],
         sumLength = new Date().getSeconds();

        for (i = -60; i <= 0; i++) {
          data.push({
            x: sumLength + i * 20,
            y: Math.random()
          });
        }
        return data;
      })()
    }]
  });
});