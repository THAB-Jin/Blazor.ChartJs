window.chartInterop = {
    charts: {},

    initChart: function (canvasId, config) {
        const ctx = document.getElementById(canvasId).getContext("2d");
        const chart = new Chart(ctx, config);
        this.charts[canvasId] = chart;
    },

    disposeChart: function (canvasId) {
        const chart = this.charts[canvasId];
        if (chart) {
            chart.destroy();
            delete this.charts[canvasId];
        }
    }
};
