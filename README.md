# zorrilla.src

Monolith repository for the Zorrilla project.

## Layout

| Path | Description |
|------|-------------|
| `SinglePageApp/` | ASP.NET Core host for the public site. `SinglePageApp/wwwroot/` is the source of the static site deployed to GitHub Pages. |
| `Zorrilla.Admin/` | Current admin app (Blazor). |
| `legacy/zorrilla.admin/` | The former `zorrilla.admin` repository (Razor Pages version), merged here with full history. Superseded by `Zorrilla.Admin/`. |
| `Zorrilla.Web.sln` | Solution for the public site. |

## GitHub Pages

The live site is served from the separate [`zorrilla.web`](https://github.com/JollyKrampus/zorrilla.web) repository at <https://jollykrampus.github.io/zorrilla.web/>. Its contents are a copy of `SinglePageApp/wwwroot/`. To publish site changes, copy the updated `wwwroot` files into `zorrilla.web` and push.
