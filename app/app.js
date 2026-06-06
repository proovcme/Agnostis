const tasks = [
  {
    id: "FAM-0241",
    title: "Шкаф архивный металлический",
    category: "Мебель",
    owner: "Илья Морозов",
    due: "12 июн",
    fop: "ADSK_Company_2026",
    status: "ready",
    statusText: "Готово к разработке",
    score: "86%",
    aiSummary:
      "ТЗ и таблица типоразмеров согласованы. ФОП покрывает 12 из 14 обязательных параметров. Для материала фасада нужен выбор из корпоративного справочника.",
    sources: [
      ["ТЗ_шкаф_архивный.pdf", "PDF · 8 стр · загружено сегодня"],
      ["Типоразмеры_шкафы.xlsx", "XLSX · 6 типов · 18 параметров"],
      ["ADSK_Company_2026.txt", "ФОП · 418 параметров"],
      ["Furniture_Metric.rft", "Шаблон · категория Furniture"],
    ],
    parameters: [
      ["ADSK_Наименование", "Text", "Shared"],
      ["ADSK_Код изделия", "Text", "Shared"],
      ["Ширина", "Length", "Family"],
      ["Высота", "Length", "Family"],
      ["Глубина", "Length", "Family"],
      ["Материал корпуса", "Material", "Family"],
    ],
    types: [
      ["Шкаф 800x400x1800", "800", "400", "1800", "серый RAL 7035"],
      ["Шкаф 900x450x1800", "900", "450", "1800", "серый RAL 7035"],
      ["Шкаф 1000x500x2000", "1000", "500", "2000", "графит RAL 7024"],
    ],
    checks: [
      ["pass", "Категория семейства", "Furniture совпадает со спецификацией"],
      ["pass", "Обязательные параметры", "12 параметров найдены в ФОП"],
      ["warn", "Материалы", "2 материала требуют выбора из справочника"],
      ["warn", "Типоразмеры", "Нужно подтвердить 6 строк перед созданием"],
    ],
    risks: [
      ["M", "medium", "Материал фасада", "В ТЗ указано два допустимых покрытия без правила выбора."],
      ["L", "low", "Артикул", "Формула артикула зависит от финального кода серии."],
    ],
    actions: [
      ["file-plus-2", "Создать параметры", "Добавить 12 shared и 2 family parameters"],
      ["table-2", "Создать типы", "Сформировать 6 типоразмеров из Excel"],
      ["clipboard-check", "Запустить проверку", "Сверить активный RFA со спецификацией"],
    ],
  },
  {
    id: "FAM-0242",
    title: "Дверь техническая EI60",
    category: "Двери",
    owner: "Анна Лебедева",
    due: "15 июн",
    fop: "DoorPack_2026",
    status: "review",
    statusText: "На проверке",
    score: "72%",
    aiSummary:
      "Геометрия и типы загружены. Проверка нашла незаполненные классификаторы и конфликт единиц у параметра толщины полотна.",
    sources: [
      ["ТЗ_дверь_EI60.docx", "DOCX · 12 стр"],
      ["EI60_types.xlsx", "XLSX · 14 типов"],
      ["DoorPack_2026.txt", "ФОП · 216 параметров"],
    ],
    parameters: [
      ["ADSK_Наименование", "Text", "Shared"],
      ["ADSK_Класс огнестойкости", "Text", "Shared"],
      ["Ширина проема", "Length", "Family"],
      ["Высота проема", "Length", "Family"],
      ["Толщина полотна", "Length", "Family"],
    ],
    types: [
      ["EI60 900x2100 L", "900", "140", "2100", "RAL 7035"],
      ["EI60 1000x2100 R", "1000", "140", "2100", "RAL 7035"],
      ["EI60 1200x2200 L", "1200", "160", "2200", "RAL 7016"],
    ],
    checks: [
      ["pass", "Типы", "14 типов найдены"],
      ["fail", "Классификатор", "ADSK_Код изделия пуст у 4 типов"],
      ["warn", "Единицы", "Толщина полотна прочитана как Text"],
      ["pass", "Файл", "Размер RFA в пределах нормы"],
    ],
    risks: [
      ["H", "high", "Классификатор", "Без кода изделие нельзя публиковать в каталог."],
      ["M", "medium", "Единицы", "Нужно привести толщину полотна к Length."],
    ],
    actions: [
      ["list-checks", "Исправить значения", "Заполнить 4 пустых кода изделия"],
      ["ruler", "Проверить единицы", "Сопоставить толщину полотна с ФОП"],
      ["send", "Вернуть на доработку", "Сформировать замечания разработчику"],
    ],
  },
  {
    id: "FAM-0238",
    title: "Светильник линейный подвесной",
    category: "Осветительные приборы",
    owner: "Сергей Ким",
    due: "18 июн",
    fop: "MEP_Light_2026",
    status: "dev",
    statusText: "В работе",
    score: "64%",
    aiSummary:
      "Спецификация готова частично. Таблица мощностей распознана, но для фотометрии нет исходного IES-файла.",
    sources: [
      ["brief_linear_light.pdf", "PDF · 5 стр"],
      ["power_table.xlsx", "XLSX · 9 типов"],
      ["MEP_Light_2026.txt", "ФОП · 302 параметра"],
    ],
    parameters: [
      ["ADSK_Наименование", "Text", "Shared"],
      ["Мощность", "Electrical Power", "Shared"],
      ["Световой поток", "Number", "Shared"],
      ["Длина", "Length", "Family"],
      ["IES файл", "Text", "Family"],
    ],
    types: [
      ["LINE 600 18W", "600", "80", "45", "18W"],
      ["LINE 1200 36W", "1200", "80", "45", "36W"],
      ["LINE 1500 48W", "1500", "80", "45", "48W"],
    ],
    checks: [
      ["warn", "Исходники", "IES-файл отсутствует"],
      ["pass", "Параметры", "9 обязательных параметров найдены"],
      ["warn", "Типы", "Нужно проверить световой поток"],
      ["pass", "Категория", "Lighting Fixtures совпадает"],
    ],
    risks: [
      ["M", "medium", "Фотометрия", "Без IES проверка световых характеристик неполная."],
      ["L", "low", "Типы", "Нужна сверка мощности и длины для 2 строк."],
    ],
    actions: [
      ["upload", "Запросить IES", "Добавить недостающий источник к заданию"],
      ["table-2", "Сверить таблицу", "Проверить 9 типов по XLSX"],
      ["plug", "Открыть в Revit", "Продолжить реализацию семейства"],
    ],
  },
  {
    id: "FAM-0235",
    title: "Воздухораспределитель круглый",
    category: "ОВиК",
    owner: "Мария Орлова",
    due: "21 июн",
    fop: "HVAC_2026",
    status: "blocked",
    statusText: "Ожидает данных",
    score: "48%",
    aiSummary:
      "Задание содержит противоречие между таблицей диаметров и PDF-каталогом. Требуется подтверждение линейки типоразмеров.",
    sources: [
      ["air_diffuser_task.pdf", "PDF · 3 стр"],
      ["diameters.xlsx", "XLSX · 11 строк"],
      ["catalog_fragment.png", "PNG · референс"],
    ],
    parameters: [
      ["ADSK_Наименование", "Text", "Shared"],
      ["Диаметр", "Length", "Family"],
      ["Расход воздуха", "Number", "Shared"],
      ["Материал", "Material", "Family"],
    ],
    types: [
      ["DIF 100", "100", "60", "35", "сталь"],
      ["DIF 125", "125", "70", "35", "сталь"],
      ["DIF 160", "160", "85", "40", "сталь"],
    ],
    checks: [
      ["fail", "Типоразмеры", "PDF и XLSX расходятся по диаметру 200"],
      ["warn", "ФОП", "Параметр расхода не найден в активном профиле"],
      ["pass", "Категория", "Air Terminals совпадает"],
    ],
    risks: [
      ["H", "high", "Типоразмеры", "Нельзя создавать типы до подтверждения таблицы."],
      ["M", "medium", "ФОП", "Нужен shared parameter для расхода воздуха."],
    ],
    actions: [
      ["message-square-warning", "Задать вопрос", "Уточнить диаметр 200 у BIM-менеджера"],
      ["file-key-2", "Обновить ФОП", "Добавить или сопоставить параметр расхода"],
      ["pause", "Приостановить", "Оставить задание до подтверждения"],
    ],
  },
];

const catalogItems = [
  ["Шкаф архивный металлический", "Мебель", "v1.4", "428 скачиваний"],
  ["Дверь техническая EI60", "Двери", "v2.1", "96 скачиваний"],
  ["Светильник линейный подвесной", "Освещение", "v1.2", "214 скачиваний"],
  ["Диффузор круглый D100-D250", "ОВиК", "v3.0", "182 скачивания"],
];

const state = {
  selectedTaskId: tasks[0].id,
  selectedTab: "sources",
  filter: "all",
  search: "",
};

const statusClass = {
  ready: "ready",
  dev: "dev",
  review: "review",
  blocked: "blocked",
};

const taskList = document.querySelector("#taskList");
const tabContent = document.querySelector("#tabContent");

function selectedTask() {
  return tasks.find((task) => task.id === state.selectedTaskId) || tasks[0];
}

function renderTasks() {
  const query = state.search.trim().toLowerCase();
  const filtered = tasks.filter((task) => {
    const matchesFilter =
      state.filter === "all" ||
      (state.filter === "in_development" && task.status === "dev") ||
      (state.filter === "review" && task.status === "review");
    const matchesSearch = `${task.id} ${task.title} ${task.category} ${task.owner}`
      .toLowerCase()
      .includes(query);

    return matchesFilter && matchesSearch;
  });

  taskList.innerHTML = filtered
    .map(
      (task) => `
      <button class="task-card ${task.id === state.selectedTaskId ? "is-active" : ""}" type="button" data-task-id="${task.id}">
        <div class="task-card-top">
          <span class="task-code">${task.id}</span>
          <span class="badge ${statusClass[task.status]}">${task.statusText}</span>
        </div>
        <div class="task-card-title">${task.title}</div>
        <div class="task-card-meta">
          <span>${task.category}</span>
          <span>${task.due}</span>
        </div>
      </button>
    `,
    )
    .join("");

  if (!filtered.length) {
    taskList.innerHTML = `<div class="empty-state">Ничего не найдено</div>`;
  }
}

function renderDetails() {
  const task = selectedTask();

  document.querySelector("#taskNumber").textContent = task.id;
  document.querySelector("#taskTitle").textContent = task.title;
  document.querySelector("#taskCategory").textContent = task.category;
  document.querySelector("#taskOwner").textContent = task.owner;
  document.querySelector("#taskDue").textContent = task.due;
  document.querySelector("#taskFop").textContent = task.fop;

  const status = document.querySelector("#taskStatus");
  status.textContent = task.statusText;
  status.className = `status-pill ${statusClass[task.status]}`;

  document.querySelector("#aiScore").textContent = `Готовность ${task.score}`;
  document.querySelector("#aiSummary").textContent = task.aiSummary;

  renderRisks(task);
  renderActions(task);
  renderTab(task);
  refreshIcons();
}

function renderRisks(task) {
  document.querySelector("#riskList").innerHTML = task.risks
    .map(
      ([letter, level, title, text]) => `
      <div class="risk-item">
        <span class="risk-level ${level}">${letter}</span>
        <div>
          <strong>${title}</strong>
          <span>${text}</span>
        </div>
      </div>
    `,
    )
    .join("");
}

function renderActions(task) {
  document.querySelector("#nextActions").innerHTML = task.actions
    .map(
      ([icon, title, text]) => `
      <button class="action-item" type="button">
        <span class="action-icon"><i data-lucide="${icon}"></i></span>
        <div>
          <strong>${title}</strong>
          <span>${text}</span>
        </div>
      </button>
    `,
    )
    .join("");
}

function renderTab(task) {
  const templates = {
    sources: renderSources,
    spec: renderSpec,
    checks: renderChecks,
    catalog: renderCatalog,
  };

  tabContent.innerHTML = templates[state.selectedTab](task);
}

function renderSources(task) {
  return `
    <div class="panel-grid">
      <section class="content-panel">
        <h3>Пакет задания</h3>
        <div class="source-list">
          ${task.sources
            .map(
              ([name, meta]) => `
            <div class="source-row">
              <div class="source-row-main">
                <strong>${name}</strong>
                <span>${meta}</span>
              </div>
              <button class="icon-button" type="button" title="Открыть файл" aria-label="Открыть файл">
                <i data-lucide="file-search"></i>
              </button>
            </div>
          `,
            )
            .join("")}
        </div>
      </section>
      <section class="content-panel">
        <h3>AI-разбор</h3>
        <div class="check-list">
          <div class="check-row">
            <span class="check-icon pass"><i data-lucide="check"></i></span>
            <div class="check-copy">
              <strong>Категория определена</strong>
              <span>${task.category}</span>
            </div>
          </div>
          <div class="check-row">
            <span class="check-icon ${task.status === "blocked" ? "fail" : "pass"}"><i data-lucide="${task.status === "blocked" ? "x" : "check"}"></i></span>
            <div class="check-copy">
              <strong>Типоразмеры извлечены</strong>
              <span>${task.types.length} строки в текущей спецификации</span>
            </div>
          </div>
          <div class="check-row">
            <span class="check-icon warn"><i data-lucide="triangle-alert"></i></span>
            <div class="check-copy">
              <strong>Требует внимания</strong>
              <span>${task.risks[0][2]}</span>
            </div>
          </div>
        </div>
      </section>
    </div>
  `;
}

function renderSpec(task) {
  return `
    <div class="panel-grid">
      <section class="content-panel">
        <h3>Параметры</h3>
        <div class="parameter-list">
          ${task.parameters
            .map(
              ([name, type, kind]) => `
            <div class="parameter-row">
              <strong>${name}</strong>
              <span class="parameter-kind">${type}</span>
              <span class="badge ${kind === "Shared" ? "ready" : "dev"}">${kind}</span>
            </div>
          `,
            )
            .join("")}
        </div>
      </section>
      <section class="content-panel">
        <h3>Готовность спецификации</h3>
        <div class="source-list">
          <div>
            <div class="progress-shell">
              <div class="progress-bar" style="width: ${task.score}"></div>
            </div>
          </div>
          <div class="check-row">
            <span class="check-icon pass"><i data-lucide="file-key-2"></i></span>
            <div class="check-copy">
              <strong>${task.fop}</strong>
              <span>Активный профиль параметров</span>
            </div>
          </div>
          <div class="check-row">
            <span class="check-icon warn"><i data-lucide="clipboard-pen"></i></span>
            <div class="check-copy">
              <strong>Чеклист приемки</strong>
              <span>${task.checks.length} пункта в текущем наборе</span>
            </div>
          </div>
        </div>
      </section>
      <section class="content-panel full">
        <h3>Типоразмеры</h3>
        <div class="type-table">
          <table>
            <thead>
              <tr>
                <th>Тип</th>
                <th>Ширина</th>
                <th>Глубина</th>
                <th>Высота</th>
                <th>Материал / значение</th>
              </tr>
            </thead>
            <tbody>
              ${task.types
                .map(
                  (row) => `
                <tr>
                  ${row.map((cell) => `<td>${cell}</td>`).join("")}
                </tr>
              `,
                )
                .join("")}
            </tbody>
          </table>
        </div>
      </section>
    </div>
  `;
}

function renderChecks(task) {
  return `
    <div class="panel-grid">
      <section class="content-panel full">
        <h3>Отчет проверки</h3>
        <div class="check-list">
          ${task.checks
            .map(
              ([stateName, title, text]) => `
            <div class="check-row">
              <span class="check-icon ${stateName}">
                <i data-lucide="${stateName === "pass" ? "check" : stateName === "warn" ? "triangle-alert" : "x"}"></i>
              </span>
              <div class="check-copy">
                <strong>${title}</strong>
                <span>${text}</span>
              </div>
              <button class="compact-button" type="button">
                <i data-lucide="arrow-right"></i>
              </button>
            </div>
          `,
            )
            .join("")}
        </div>
      </section>
    </div>
  `;
}

function renderCatalog(task) {
  return `
    <div class="panel-grid">
      <section class="content-panel full">
        <h3>Ближайшие семейства</h3>
        <div class="catalog-list">
          ${catalogItems
            .map(
              ([name, category, version, downloads]) => `
            <div class="catalog-row">
              <div class="catalog-main">
                <strong>${name}</strong>
                <span>${category} · ${version} · ${downloads}</span>
              </div>
              <button class="compact-button" type="button">
                <i data-lucide="${name === task.title ? "git-compare-arrows" : "download"}"></i>
                <span>${name === task.title ? "Сравнить" : "Скачать"}</span>
              </button>
            </div>
          `,
            )
            .join("")}
        </div>
      </section>
    </div>
  `;
}

function refreshIcons() {
  if (window.lucide) {
    window.lucide.createIcons();
  }
}

document.addEventListener("click", (event) => {
  const taskButton = event.target.closest("[data-task-id]");
  if (taskButton) {
    state.selectedTaskId = taskButton.dataset.taskId;
    renderTasks();
    renderDetails();
  }

  const tabButton = event.target.closest("[data-tab]");
  if (tabButton) {
    state.selectedTab = tabButton.dataset.tab;
    document
      .querySelectorAll(".tabs button")
      .forEach((button) => button.classList.toggle("is-active", button === tabButton));
    renderTab(selectedTask());
    refreshIcons();
  }

  const filterButton = event.target.closest("[data-filter]");
  if (filterButton) {
    state.filter = filterButton.dataset.filter;
    document
      .querySelectorAll(".segmented button")
      .forEach((button) => button.classList.toggle("is-selected", button === filterButton));
    renderTasks();
  }
});

document.querySelector("#globalSearch").addEventListener("input", (event) => {
  state.search = event.target.value;
  renderTasks();
});

renderTasks();
renderDetails();
