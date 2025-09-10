// I think this is a module -> should we tag with .mjs?
export function initChart(canvasId, config) {
    const ctx = document.getElementById(canvasId).getContext("2d");
    const chart = new Chart(ctx, config);
    return chart;
}

export function disposeChart(chart) {
    chart.destroy();
}
