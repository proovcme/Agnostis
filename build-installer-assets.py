"""Build ARTEL Windows installer assets from the repo-native vector mark."""
from pathlib import Path
import sys

from PIL import Image, ImageDraw

ROOT = Path(__file__).resolve().parent
ASSETS = ROOT / "installer" / "assets"
SVG = ASSETS / "artel-mark.svg"

sys.path.insert(0, str(ROOT.parents[1]))
from tools.build_icons import _render_pillow  # noqa: E402


def main() -> int:
    ASSETS.mkdir(parents=True, exist_ok=True)
    base = ASSETS / "artel-mark-256.png"
    _render_pillow(SVG, 256, base)
    icon = Image.open(base).convert("RGBA")
    icon.save(ASSETS / "ARTEL.ico", sizes=[(16, 16), (24, 24), (32, 32), (48, 48), (64, 64), (128, 128), (256, 256)])

    large = Image.new("RGB", (164, 314), "#F4F3EF")
    large_icon = icon.resize((116, 116), Image.Resampling.LANCZOS)
    large.paste(large_icon, (24, 48), large_icon)
    draw = ImageDraw.Draw(large)
    draw.rounded_rectangle((24, 190, 140, 194), radius=2, fill="#D8D6CF")
    draw.rounded_rectangle((24, 210, 118, 216), radius=3, fill="#176C52")
    draw.rounded_rectangle((24, 230, 132, 236), radius=3, fill="#A7AAA3")
    large.save(ASSETS / "wizard-large.bmp")

    small = Image.new("RGB", (55, 55), "#F4F3EF")
    small_icon = icon.resize((43, 43), Image.Resampling.LANCZOS)
    small.paste(small_icon, (6, 6), small_icon)
    small.save(ASSETS / "wizard-small.bmp")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
